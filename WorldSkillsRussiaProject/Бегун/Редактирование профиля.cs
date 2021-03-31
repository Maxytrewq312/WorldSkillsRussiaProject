using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorldSkillsRussiaProject.Бегун
{
    public partial class Редактирование_профиля : Form
    {
        public string email;
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataRow row;
        string imageLocation = "";
        public Редактирование_профиля()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = checkToAdd();
            if (result == "ОК")
            {
                try
                {
                    connectionSql.Open();

                    string name = textBox4.Text;
                    string lastName = textBox5.Text;
                    string gender = comboBox1.Text;
                    string data = dateTimePicker1.Value.ToString();
                    string country = comboBox2.SelectedValue.ToString();

                    byte[] picture = (byte[])row[6];
                    if (imageLocation != "")
                    {
                        FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binaryReader = new BinaryReader(fileStream);
                        picture = binaryReader.ReadBytes((int)fileStream.Length);
                    }

                    string password = (string)row[7];
                    if (textBox2.Text != "" || textBox3.Text != "")
                    {
                        string resultPassword = changePassword();
                        if (resultPassword == "ОК")
                        {
                            password = textBox2.Text;
                        }
                        else
                        {
                            MessageBox.Show(resultPassword);
                        }
                    }

                    command = new SqlCommand($"update[dbo].[User] set Password = '{password}', FirstName = '{name}', LastName = '{lastName}', Picture = @img where Email = '{label7.Text}'", connectionSql);
                    command.Parameters.Add(new SqlParameter("@img", picture));
                    command.ExecuteNonQuery();

                    command = new SqlCommand($"update[dbo].[Runner] set Gender = '{gender}', CountryCode = '{country}', DateOfBirth = CONVERT(datetime, '{data}' where Email = '{label7.Text}'", connectionSql);
                    
                    command.ExecuteNonQuery();

                    Редактирование_профиля.ActiveForm.Hide();
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
        private void loadGender() // Загрузка полов и выгрузка в список
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

        private void loadCountries() // Загрузка стран и выгразка в список 
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT [CountryCode], [CountryName] from Country", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                comboBox2.DataSource = dataSet.Tables[0];
                comboBox2.DisplayMember = "CountryName";
                comboBox2.ValueMember = "CountryCode";

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

        private string checkToAdd() //Все проверки для текста
        {
            DateTime today = DateTime.Today;
            if (today.Subtract(dateTimePicker1.Value).Days / 365 < 10)
                return "Вам еще не исполнилось 10 лет";

            if (!textBox4.Text.All(c => char.IsLetter(c)))
                return "В имени есть лишние символы";

            if (!textBox5.Text.All(c => char.IsLetter(c)))
                return "В фамилии есть лишние символы";

            return "ОК";
        }

        private string changePassword() //Все проверки для паролей
        {
            if (textBox2.Text.Length < 6 || !Regex.IsMatch(textBox2.Text, @"[0-9]") || !Regex.IsMatch(textBox2.Text, @"[A-Z]") || !Regex.IsMatch(textBox2.Text, @"[!@#$%^]"))
                return "Неверно введен пароль. Пароль должен имень минимум 6 символов, 1 прописную букву, 1 цифру и один из этих символов: !@#$%^. Изменение пароля будет пропущено";

            if (textBox2.Text != textBox3.Text)
                return "Пароли не совпадают. Изменение пароля будет пропущено";

            return "ОК";
        }

        private void loadData() //Загрузка информации о бегуне
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT dbo.Runner.Email, dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Gender, dbo.Runner.DateOfBirth, dbo.Country.CountryName, dbo.[User].Picture, dbo.[User].Password FROM dbo.Runner INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode WHERE (dbo.Runner.Email = '{Авторизация.email}')", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                row = dataSet.Tables[0].Rows[0];
                label7.Text = row[0].ToString();
                textBox4.Text = row[1].ToString();
                textBox5.Text = row[2].ToString();
                comboBox1.Text = row[3].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row[4].ToString());
                comboBox2.Text = row[5].ToString();

                if (!((byte[])row[6]).All(c => c == 0))
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])row[6]);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
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

        private void Редактирование_профиля_Load(object sender, EventArgs e)
        {
            loadGender();
            loadCountries();
            loadData();
        }
    }
}
