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
        public Меню_марафона()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            О_марафоне about = new О_марафоне();
            about.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Длиетльность_марафона dl = new Длиетльность_марафона();
            dl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
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
    }
}
