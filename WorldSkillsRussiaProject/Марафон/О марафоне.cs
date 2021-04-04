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
    public partial class О_марафоне : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public О_марафоне()
        {
            InitializeComponent();
        }

        private void mapPictureBox_Click(object sender, EventArgs e)
        {
            О_марафоне.ActiveForm.Hide();
            Интерактивная_карта form = new Интерактивная_карта();
            form.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Меню_марафона mm = new Меню_марафона();
            mm.Show();
        }
    }
}
