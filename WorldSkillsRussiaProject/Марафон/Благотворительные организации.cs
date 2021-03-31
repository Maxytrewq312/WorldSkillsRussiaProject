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

namespace WorldSkillsRussiaProject.Марафон
{
    public partial class Благотворительные_организации : Form
    {
        string connection = @"Data Source=DESKTOP-TSPOI6V\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public Благотворительные_организации()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void Благотворительные_организации_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    connectionSql.Open();

                    dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                    DataSet dataSet = new DataSet();

                    dataAdapter.Fill(dataSet);
                    UserControl1[] control = new UserControl1[dataSet.Tables[0].Rows.Count];
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        control[i] = new UserControl1();
                        control[i].Title = dataSet.Tables[0].Rows[i][1].ToString();
                        control[i].Message = dataSet.Tables[0].Rows[i][2].ToString();
                        control[i].Check = false;
                        control[i].Icon = Image.FromFile(@"C:\Users\Максим\Desktop\Задание на практику\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][3].ToString());
                        flowLayoutPanel1.Controls.Add(control[i]);
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
