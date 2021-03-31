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
    public partial class Мои_Результаты : Form
    {
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        public string email;
        int minAge, maxAge = 0;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        DataTable table;
        public Мои_Результаты()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void Мои_Результаты_Load(object sender, EventArgs e)
        {
            try
            {
                takeAgesAndGender();
                connectionSql.Open();

                string query = "SELECT [RegistrationId], [MarathonName] as 'Марафон', [EventTypeName] as 'Дистанция', CONVERT(nvarchar, CONVERT(datetime, [RaceTime]/100000.0), 8)  AS 'Время', " +
                    "(select[PlaceId] from[Place]([MarathonName], [EventTypeName]) where[RegId] = [RegistrationId]) as 'Общее место'," +
                    $"(select[PlaceId] from[PlaceYear]([MarathonName], [EventTypeName], {minAge}, {maxAge}) where[RegId] = [RegistrationId]) as 'Место по категории'" +
                    "FROM[RegistrationEvent] " +
                    "inner join[Event] on[RegistrationEvent].[EventId] = [Event].[EventId] " +
                    "inner join[Marathon] on Event.[MarathonId] = [Marathon].[MarathonId] " +
                    "inner join[EventType] on Event.EventTypeId = EventType.EventTypeId " +
                    "where[RegistrationId] = (select RegistrationId from Registration where RunnerId = " +
                    $"(select RunnerId from Runner where Email = '{Авторизация.email}'))";

                dataAdapter = new SqlDataAdapter(query, connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].Visible = false;
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
        private void takeAgesAndGender()//Выставляем диапазон возраста в зависимости от возраста нашего пользователя
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter($"select YEAR(GETDATE())-YEAR([DateOfBirth]), [Gender] from [Runner] where  Email = '{Авторизация.email}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                int age = (int)dataSet.Tables[0].Rows[0][0];
                label5.Text = (string)dataSet.Tables[0].Rows[0][1];

                if (age < 18)
                {
                    minAge = 0;
                    maxAge = 17;
                }
                if (age >= 18 && age <= 29)
                {
                    minAge = 18;
                    maxAge = 29;
                }
                if (age >= 30 && age <= 39)
                {
                    minAge = 30;
                    maxAge = 39;
                }
                if (age >= 40 && age <= 55)
                {
                    minAge = 40;
                    maxAge = 55;
                }
                if (age >= 56 && age <= 70)
                {
                    minAge = 56;
                    maxAge = 70;
                }
                if (age > 70)
                {
                    minAge = 71;
                    maxAge = 120;
                }
                label6.Text = $"{minAge}-{maxAge}";
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
    }
}
