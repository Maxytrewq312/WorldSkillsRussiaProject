using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WorldSkillsRussiaProject.Бегун
{
    public partial class Регистрация_бегуна : Form
    {
        public string email;
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        string imageLocation = "";

        public Регистрация_бегуна(string email)
        {
            InitializeComponent();
            this.email = email;
            connectionSql = new SqlConnection(connection);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = checkToAdd();
            if (result == "ОК")
            {
                SqlConnection conn = new SqlConnection(Connection.GetString());
                conn.Open();
                try
                {
                    DateTime dateOfBirth = Convert.ToDateTime(dateTimePicker1.Value);
                    connectionSql.Open();

                    command = new SqlCommand($"insert into [dbo].[User] (Email, Password, FirstName, LastName, RoleId, Picture) values('{textBox1.Text}', '{textBox2.Text}','{textBox4.Text.ToUpper()}','{textBox5.Text.ToUpper()}','R', '{textBox6.Text.ToUpper()}')", connectionSql);
                    command.ExecuteNonQuery();
                    connectionSql.Close();



                    connectionSql.Open();
                    command = new SqlCommand($"insert into [dbo].[Runner] (Email, Gender, DateOfBirth, CountryCode) values('{textBox1.Text}','{comboBox1.Text}', '{dateTimePicker1.Value}',(select [CountryCode] from [Country] where CountryName = '{comboBox2.Text}'))", connectionSql);

                    command.ExecuteNonQuery();

                    Авторизация.email = textBox1.Text;
                    Регистрация_бегуна.ActiveForm.Hide();
                    Регистрация_на_марафон form = new Регистрация_на_марафон(email);
                    form.Show();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    connectionSql.Close();
                }
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Файлы JPG (*.jpg)|*.jpg|Файлы PNG (*.png)|*.png";
                dialog.Title = "Выбрать фотографию";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    pictureBox1.ImageLocation = imageLocation;
                    textBox6.Text = dialog.FileName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void loadGender() //загрузка полов и выгрузка их в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from Gender", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                comboBox1.DataSource = dataSet.Tables[0];
                comboBox1.DisplayMember = "Gender";
                comboBox1.ValueMember = "Gender";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
        }

        private void loadCountries() //загрузка стран и выгрузка их в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT [CountryName] from Country", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                comboBox2.DataSource = dataSet.Tables[0];
                comboBox2.DisplayMember = "CountryName";
                comboBox2.ValueMember = "CountryName";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
        }
        private string checkToAdd() //все проверки на текст, пароль и имейл
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox2.Text == "")
                return "Не все поля заполнены";

            try { var mail = new System.Net.Mail.MailAddress(textBox1.Text); }
            catch { return "Некорректный e-mail адрес"; }

            if (textBox2.Text.Length < 6 || !Regex.IsMatch(textBox2.Text, @"[0-9]") || !Regex.IsMatch(textBox2.Text, @"[A-Z]") || !Regex.IsMatch(textBox2.Text, @"[!@#$%^]"))
                return "Неверно введен пароль. Пароль должен имень минимум 6 символов, 1 прописную букву, 1 цифру и один из этих символов: !@#$%^";

            if (textBox2.Text != textBox3.Text)
                return "Пароли не совпадают";

            DateTime today = DateTime.Today;
            if (today.Subtract(dateTimePicker1.Value).Days / 365 < 10)
                return "Вам еще не исполнилось 10 лет";

            if (!textBox4.Text.All(c => char.IsLetter(c)))
                return "В имени есть лишние символы";

            if (!textBox5.Text.All(c => char.IsLetter(c)))
                return "В фамилии есть лишние символы";

            return "ОК";
        }

        private void Регистрация_бегуна_Load(object sender, EventArgs e)
        {
            loadGender();
            loadCountries();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация_бегуна.ActiveForm.Hide();
            MainMenu form = new MainMenu();
            form.Show();
        }
    }
}
