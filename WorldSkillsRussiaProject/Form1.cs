using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkillsRussiaProject
{
    public partial class MainMenu : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public string email;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Бегун.Спонсор_бегуна sponBeg = new Бегун.Спонсор_бегуна();
            sponBeg.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Бегун.Авторизация avt = new Бегун.Авторизация(email);
            avt.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Бегун.Главное_меню_бегуна men = new Бегун.Главное_меню_бегуна(email);
            men.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Марафон.Меню_марафона mm = new Марафон.Меню_марафона();
            mm.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            labelTime.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
    }
}
