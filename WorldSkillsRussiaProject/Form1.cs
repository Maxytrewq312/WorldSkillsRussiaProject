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
        public string email;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Бегун.Спонсор_бегуна sponBeg = new Бегун.Спонсор_бегуна();
            sponBeg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Бегун.Авторизация avt = new Бегун.Авторизация(email);
            avt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Бегун.Главное_меню_бегуна men = new Бегун.Главное_меню_бегуна(email);
            men.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Марафон.Меню_марафона mm = new Марафон.Меню_марафона();
            mm.Show();
        }
    }
}
