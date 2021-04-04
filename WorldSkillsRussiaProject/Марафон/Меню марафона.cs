using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkillsRussiaProject.Марафон
{
    public partial class Меню_марафона : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public Меню_марафона()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            О_марафоне about = new О_марафоне();
            about.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Длиетльность_марафона dl = new Длиетльность_марафона();
            dl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Благотворительные_организации borg = new Благотворительные_организации();
            borg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BMI_Калькулятор bmi = new BMI_Калькулятор();
            bmi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BMR_Калькулятор bmr = new BMR_Калькулятор();
            bmr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            labelTime.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
