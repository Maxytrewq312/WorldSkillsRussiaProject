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
    public partial class Поступление : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlCommand command;
        public Поступление()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();
                if (int.TryParse(idTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set amount = amount + {Convert.ToInt32(idTextBox.Text)} where InvId = 1", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(rfidTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set amount = amount + {Convert.ToInt32(rfidTextBox.Text)} where InvId = 2", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(baseballTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set amount = amount + {Convert.ToInt32(baseballTextBox.Text)} where InvId = 3", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(waterTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set amount = amount + {Convert.ToInt32(waterTextBox.Text)} where InvId = 4", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(tshirtTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set amount = amount + {Convert.ToInt32(tshirtTextBox.Text)} where InvId = 5", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(souvenirTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set amount = amount + {Convert.ToInt32(souvenirTextBox.Text)} where InvId = 6", connectionSql);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Данные успешно обновлены!");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            labelTime.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
    }
}
