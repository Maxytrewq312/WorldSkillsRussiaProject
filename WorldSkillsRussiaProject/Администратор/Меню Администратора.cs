using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkillsRussiaProject.Admin
{
    public partial class Меню_Администратора : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public string email;
        public Меню_Администратора(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void Меню_Администратора_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Администратор.Управление_волонтерами up = new Администратор.Управление_волонтерами();
            up.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Администратор.Управление_Благотворительными_организациями upr = new Администратор.Управление_Благотворительными_организациями();
            upr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            labelTime.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void label4_Click(object sender, EventArgs e)
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
            Администратор.Инвентарь ins = new Администратор.Инвентарь();
            ins.Show();
        }
    }
}
