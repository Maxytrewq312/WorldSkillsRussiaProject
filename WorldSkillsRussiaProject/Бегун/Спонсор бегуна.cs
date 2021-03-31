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
    public partial class Спонсор_бегуна : Form
    {
        int sponsorstvo;
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        DataTable table;
        public Спонсор_бегуна()
        {
            InitializeComponent();
            ShowBeg();
            connectionSql = new SqlConnection(connection);
            comboBoxBeg.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Спонсор_бегуна_Load(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Registration.RegistrationId, dbo.[User].FirstName + ' ' + dbo.[User].LastName + ' - ' + CONVERT(varchar, dbo.Registration.RunnerId) + ' (' + dbo.Country.CountryName + ')' AS Runner, dbo.Charity.CharityName, dbo.Charity.CharityLogo, dbo.Charity.CharityDescription FROM dbo.Charity INNER JOIN dbo.Registration ON dbo.Charity.CharityId = dbo.Registration.CharityId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                table = dataSet.Tables[0];
                comboBoxBeg.DataSource = table;
                comboBoxBeg.DisplayMember = "Runner";
                comboBoxBeg.ValueMember = "RegistrationId";

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
        void ShowBeg()
        {
            comboBoxBeg.Items.Clear();
            foreach (RegistrationEvent registrationEvent in Program.WSRP.RegistrationEvent)
            {
                string[] item = { registrationEvent.Registration.Runner.User.FirstName + " " + registrationEvent.Registration.Runner.User.LastName
                +" - " + registrationEvent.BibNumber.ToString() + "("+registrationEvent.Registration.Runner.Country.CountryName+")"};
                comboBoxBeg.Items.Add(string.Join(" ", item));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sponsorstvo = Convert.ToInt32(textBox1.Text);
                if (sponsorstvo >= 0)
                {
                    sponsorstvo = sponsorstvo + 10;
                    textBox1.Text = Convert.ToString(sponsorstvo);
                    label4.Text = "$" + Convert.ToString(sponsorstvo);
                }
            }
            catch
            {
                MessageBox.Show("Введите значение в текстовое поле", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sponsorstvo = Convert.ToInt32(textBox1.Text);
                if (sponsorstvo > 9)
                {
                    sponsorstvo = sponsorstvo - 10;
                    textBox1.Text = Convert.ToString(sponsorstvo);
                    label4.Text = "$" + Convert.ToString(sponsorstvo);
                }
            }
            catch
            {
                MessageBox.Show("Введите значение в текстовое поле", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "$" + textBox1.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "1234 1234 1234 1234")
            {
                textBox5.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Ваше имя")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Ваше имя";
            }
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Владелец карты")
            {
                textBox4.Text = "";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "1234 1234 1234 1234")
            {
                textBox5.Text = "";
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "01")
            {
                textBox6.Text = "";
            }
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "2021")
            {
                textBox8.Text = "";
            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "123")
            {
                textBox7.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Владелец карты";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "1234 1234 1234 1234";
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "01";
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "2021";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "123";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string check = checkToAdd();
            if (check == "ОК")
            {
                try
                {
                    connectionSql.Open();

                    command = new SqlCommand($"insert into [Sponsorship] (SponsorName, RegistrationId, Amount) values ('{textBox2.Text.ToUpper()}', {comboBoxBeg.SelectedValue}, {textBox1.Text}.00)", connectionSql);
                    command.ExecuteNonQuery();
                    int s = Convert.ToInt32(textBox1.Text);
                    string s1 = Convert.ToString(comboBoxBeg.Text);
                    Подтверждение podt = new Подтверждение(s, s1);
                    DataRowView rowRunner = (DataRowView)comboBoxBeg.SelectedItem;
                    podt.label5.Text = label11.Text;
                    Close();
                    podt.Show();
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
                MessageBox.Show(check);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBeg.SelectedIndex != -1)
            {
                DataRow dataRow = table.Rows[Convert.ToInt32(comboBoxBeg.SelectedIndex)];
                label11.Text = dataRow[2].ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBoxBeg.SelectedIndex) != -1)
            {
                DataRow dataRow = table.Rows[Convert.ToInt32(comboBoxBeg.SelectedIndex)];
                Информация_о_спонсоре form = new Информация_о_спонсоре();
                form.labelName.Text = label11.Text;
                form.labelDesk.Text = dataRow[4].ToString();
                form.pictureBoxLogo.Image = Image.FromFile(@"C:\Users\Максим\Desktop\Задание на практику\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\marathon-skills-2016-charity-data\" + dataRow[3].ToString());
                form.ShowDialog();
            }
        }
        private string checkToAdd() //все проверки на текст, пароль и имейл
        {
            if (textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox8.Text == "" || textBox7.Text == "")
                return "Не все поля заполнены";

            if (Convert.ToInt32(textBox1.Text) == 0)
                return "Пожертвование не может быть равно 0";

            if (Convert.ToInt32(textBox6.Text) == 0 || Convert.ToInt32(textBox6.Text) > 12)
                return "Некорректный ввод месяца в сроке действия";

            if (Convert.ToInt32(textBox8.Text) < 2021)
                return "Некорректный ввод года в сроке действия";

            return "ОК";
        }
    }
}
