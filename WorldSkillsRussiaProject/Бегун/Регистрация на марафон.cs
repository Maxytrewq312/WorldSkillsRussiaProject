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
    public partial class Регистрация_на_марафон : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public string email;
        int amount = 0;
        int amountKit = 0;
        char raceKit = 'A';
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        DataTable table;
        public Регистрация_на_марафон(string email)
        {
            InitializeComponent();
            this.email = email;
            connectionSql = new SqlConnection(connection);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        if ((checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) && Convert.ToInt32(textBox1.Text) >= amount)
        {
            try
            {
                 connectionSql.Open(); 
                 command = new SqlCommand($"insert into [Registration] (RunnerId, RegistrationDateTime, RaceKitOptionId, RegistrationStatusId, Cost, CharityId, SponsorshipTarget) values ((select [RunnerId] from [Runner] where [Email] = '{Авторизация.email}'), GETDATE(), '{raceKit}', 1, {amountKit}, {comboBox1.SelectedValue}, {textBox1.Text})", connectionSql);
                 command.ExecuteNonQuery();
                 Random random = new Random();
            if (checkBox1.Checked)
            {
                 command = new SqlCommand($"insert into RegistrationEvent (RegistrationId, EventId, BibNumber) values ((select RegistrationId from Registration where [RunnerId] = (select [RunnerId] from [Runner] where [Email] = '{Авторизация.email}')),'{eventSelect("FM")}',{random.Next(1727)})", connectionSql);
                 command.ExecuteNonQuery();
            }
            if (checkBox2.Checked)
            {
                 command = new SqlCommand($"insert into RegistrationEvent (RegistrationId, EventId, BibNumber) values ((select RegistrationId from Registration where [RunnerId] = (select [RunnerId] from [Runner] where [Email] = '{Авторизация.email}')),'{eventSelect("HM")}',{random.Next(1727)})", connectionSql);
                 command.ExecuteNonQuery();
            }
            if (checkBox3.Checked)
            {
                 command = new SqlCommand($"insert into RegistrationEvent (RegistrationId, EventId, BibNumber) values ((select RegistrationId from Registration where [RunnerId] = (select [RunnerId] from [Runner] where [Email] = '{Авторизация.email}')),'{eventSelect("FR")}',{random.Next(1727)})", connectionSql);
                 command.ExecuteNonQuery();
            }
            ActiveForm.Hide();
            Бегун.ThankYouForm ty = new ThankYouForm();
            ty.Show();
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
                MessageBox.Show("Выберите вид марафона или проверьте сумму взноса");
        }
      }
        private string eventSelect(string marathonType) //Выбор марафона, к которому привяжется пользователь
        {
            try
            {
                dataAdapter = new SqlDataAdapter($"SELECT [EventId] FROM [Marathon1].[dbo].[Event] where EventTypeId = '{marathonType}'", connectionSql);
                DataSet dataSource = new DataSet();

                dataAdapter.Fill(dataSource);
                List<string> allEvents = new List<string>();
                for (int i = 0; i < dataSource.Tables[0].Rows.Count; i++)
                {
                    allEvents.Add((string)dataSource.Tables[0].Rows[i][0]);
                }
                Random random = new Random();
                return allEvents[random.Next(allEvents.Count - 1)];

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация_на_марафон.ActiveForm.Hide();
            Меню_бегуна form = new Меню_бегуна(email);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Информация_о_спонсоре io = new Информация_о_спонсоре();
            try
            {
                io.labelName.Text = (string)table.Rows[(int)comboBox1.SelectedValue - 1][1];
                io.labelDesk.Text = (string)table.Rows[(int)comboBox1.SelectedValue - 1][2];
                io.pictureBoxLogo.Image = Image.FromFile(@"C:\Users\Максим\Desktop\Задание на практику\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\marathon-skills-2016-charity-data\" + table.Rows[(int)comboBox1.SelectedValue - 1][3].ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            io.ShowDialog();
        }

        private void Регистрация_на_марафон_Load(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                comboBox1.DataSource = dataSet.Tables[0];
                comboBox1.DisplayMember = "CharityName";
                comboBox1.ValueMember = "CharityId";

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                amount += 145;
            else
                amount -= 145;
            label8.Text = (amount + amountKit).ToString() + '$';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                amount += 75;
            else
                amount -= 75;
            label8.Text = (amount + amountKit).ToString() + '$';
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                amount += 20;
            else
                amount -= 20;
            label8.Text = (amount + amountKit).ToString() + '$';
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                raceKit = 'A';
                amountKit = 0;
                label8.Text = (amount + amountKit).ToString() + '$';
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                amountKit = 20;
                raceKit = 'B';
                label8.Text = (amount + amountKit).ToString() + '$';
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                amountKit = 45;
                raceKit = 'C';
                label8.Text = (amount + amountKit).ToString() + '$';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
