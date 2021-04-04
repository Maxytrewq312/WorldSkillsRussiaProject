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

namespace WorldSkillsRussiaProject.Бегун
{
    public partial class Авторизация : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public static string email;
        public Авторизация(string email)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Одно или несколько обязательных полей для ввода (отмеченных знаком *) не были заполнены", "Оповещение системы");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Connection.GetString());
                conn.Open();

                SqlCommand command = new SqlCommand($"SELECT[Email], [Password], [RoleId] FROM[dbo].[User] WHERE[Email] = '{textBox1.Text}' and[Password] = '{textBox2.Text}'", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Пользователь с таким email и паролем не найден! Удостоверьтесь в корректности введенных данных.", "Оповещение системы");
                    }
                    else
                    {
                        TestingForm tf = new TestingForm(email);
                        tf.Show();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            labelTime.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
