using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkillsRussiaProject.Бегун
{
    public partial class Меню_бегуна : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public string email;
        public Меню_бегуна(string email)
        {
            this.email = email; 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Регистрация_на_марафон regm = new Регистрация_на_марафон(email);
            regm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Редактирование_профиля rp = new Редактирование_профиля();
            rp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Мои_Результаты mr = new Мои_Результаты();
            mr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Мои_спонсоры ms = new Мои_спонсоры();
            ms.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Контакты kh = new Контакты();
            kh.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            labelTime.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
