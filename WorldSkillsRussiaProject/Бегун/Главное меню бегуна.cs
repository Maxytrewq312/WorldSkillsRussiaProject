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
    public partial class Главное_меню_бегуна : Form
    {
        public string email;
        public Главное_меню_бегуна(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Авторизация avt = new Авторизация(email);
            avt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация_бегуна reg = new Регистрация_бегуна(email);
            reg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
