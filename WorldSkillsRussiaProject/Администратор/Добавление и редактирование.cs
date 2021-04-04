using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WorldSkillsRussiaProject.Администратор
{
    public partial class Добавление_и_редактирование : Form
    {
        public string email;
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        string imageLocation = "";
        string imageName = "";
        public Добавление_и_редактирование()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT * from Charity where CharityName = '{nameTextBox.Text}' ", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    command = new SqlCommand($"insert into Charity(CharityName,  CharityDescription, CharityLogo) values ('{nameTextBox.Text}','{descriptionTextBox.Text}','{imageName}')", connectionSql);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Организация успешно добавлена");
                }
                else
                {
                    if (imageName == "")
                    {
                        FileInfo fileInfo = new FileInfo(photoTextBox.Text);
                        imageName = fileInfo.Name;
                    }
                    command = new SqlCommand($"update Charity set CharityName = '{nameTextBox.Text}', CharityDescription = '{descriptionTextBox.Text}', CharityLogo = '{imageName}' where CharityId = {Convert.ToInt32(dataSet.Tables[0].Rows[0][0])} ", connectionSql);
                    command.ExecuteNonQuery();
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
        public void loadChairity() 
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

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

        private void photoButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Файлы JPG (*.jpg)|*.jpg|Файлы PNG (*.png)|*.png|Все файлы (*.*)|*.*";
                dialog.Title = "Выбрать фотографию";
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    imageLocation = dialog.FileName.ToString();
                    logoPictureBox.ImageLocation = imageLocation;
                    photoTextBox.Text = dialog.FileName;
                    FileInfo fileInfo = new FileInfo(imageLocation);
                    imageName = fileInfo.Name;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Добавление_и_редактирование_Load(object sender, EventArgs e)
        {
            loadChairity();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            labelTime.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Admin.Меню_Администратора mm = new Admin.Меню_Администратора(email);
            mm.Show();
        }
    }
}
