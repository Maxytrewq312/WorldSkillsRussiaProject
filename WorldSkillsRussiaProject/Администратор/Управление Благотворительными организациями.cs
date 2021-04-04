using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorldSkillsRussiaProject.Администратор
{
    public partial class Управление_Благотворительными_организациями : Form
    {
        public string email;
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public Управление_Благотворительными_организациями()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Управление_Благотворительными_организациями.ActiveForm.Hide();
            Добавление_и_редактирование db = new Добавление_и_редактирование();
            db.Show();
        }
        public void charity() //Вызгурзка организаций из базы данных и настройка карточки
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                Марафон.UserControl1[] Control = new Марафон.UserControl1[dataSet.Tables[0].Rows.Count];
                DataTable table = new DataTable();
                int i = 0; while (i < dataSet.Tables[0].Rows.Count)
                {

                    Control[i] = new Марафон.UserControl1();
                    Control[i].Title = dataSet.Tables[0].Rows[i][1].ToString();
                    Control[i].Message = dataSet.Tables[0].Rows[i][2].ToString();
                    Control[i].Check = true;
                    Control[i].ImageLocation = @"C:\Users\Максим\Desktop\Задание на практику\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][3].ToString();
                    Control[i].Icon = Bitmap.FromFile(@"C:\Users\Максим\Desktop\Задание на практику\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][3].ToString());
                    if (organizationLayoutPanel.Controls.Count < 0)
                    {
                        organizationLayoutPanel.Controls.Clear();
                    }
                    else
                    {
                        organizationLayoutPanel.Controls.Add(Control[i]);
                    }
                    i++;
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

        private void Управление_Благотворительными_организациями_Load(object sender, EventArgs e)
        {
            charity();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            label1.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
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
