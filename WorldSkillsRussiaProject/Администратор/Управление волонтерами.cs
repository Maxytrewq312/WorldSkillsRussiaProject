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

namespace WorldSkillsRussiaProject.Администратор
{
    public partial class Управление_волонтерами : Form
    {
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public Управление_волонтерами()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        public void loadVolunters() //Выгрузка из бд всех волонтеров
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Volunteer.VolunteerId, dbo.Country.CountryCode, dbo.Volunteer.LastName AS Фамилия, dbo.Volunteer.FirstName AS Имя, dbo.Country.CountryName AS Страна, dbo.Gender.Gender AS Пол FROM    dbo.Country INNER JOIN dbo.Volunteer ON dbo.Country.CountryCode = dbo.Volunteer.CountryCode INNER JOIN dbo.Gender ON dbo.Volunteer.Gender = dbo.Gender.Gender", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                volunterDataGrid.DataSource = dataSet.Tables[0];
                volunterDataGrid.Columns[0].Visible = false;
                volunterDataGrid.Columns[1].Visible = false;
                volunterNumberLabel.Text = dataSet.Tables[0].Rows.Count.ToString();

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
        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void Управление_волонтерами_Load(object sender, EventArgs e)
        {
            loadVolunters();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Управление_волонтерами.ActiveForm.Hide();
            Загрузка_волонтеров form = new Загрузка_волонтеров();
            form.Show();
        }
    }
}
