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
    public partial class Мои_спонсоры : Form
    {
        public string email;
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public Мои_спонсоры()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadCharity() //загрузка организации
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("select [CharityName], [CharityDescription], [CharityLogo] from Registration " +
                    "inner join Charity on[Registration].[CharityId] = [Charity].[CharityId] " +
                    $"where RunnerId = (select RunnerId from Runner where Email = '{Авторизация.email}')", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                infoLabel.Text = (string)dataSet.Tables[0].Rows[0][0];
                descriptionTextBox.Text = (string)dataSet.Tables[0].Rows[0][1];
                organizationPictureBox.Image = Bitmap.FromFile(@"C:\Users\Максим\Desktop\Задание на практику\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\marathon-skills-2016-charity-data\" + (string)dataSet.Tables[0].Rows[0][2]);

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

        private void loadSponsors() 
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT [SponsorName], [Amount] from [Sponsorship] where RegistrationId = (select RegistrationId from Registration where RunnerId = (select RunnerId from Runner where Email = '{Авторизация.email}'))", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                int total = 0;
                UserControl2[] Control = new UserControl2[dataSet.Tables[0].Rows.Count];
                DataTable Table = new DataTable();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Control[i] = new UserControl2();
                    Control[i].NameLabel = dataSet.Tables[0].Rows[i][0].ToString();
                    Control[i].Amount = '$' + dataSet.Tables[0].Rows[i][1].ToString();
                    total += Convert.ToInt32(dataSet.Tables[0].Rows[i][1]);
                    if (flowLayoutPanel.Controls.Count < 0)
                    {
                        flowLayoutPanel.Controls.Clear();
                    }
                    else
                    {
                        flowLayoutPanel.Controls.Add(Control[i]);
                    }
                }
                totalLabel.Text = "Всего $" + total.ToString();

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

        private void Мои_спонсоры_Load(object sender, EventArgs e)
        {
            loadCharity();
            loadSponsors();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            labelTime.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Меню_бегуна mb = new Меню_бегуна(email);
            mb.Show();
        }
    }
}
