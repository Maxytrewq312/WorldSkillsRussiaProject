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
        public string email;
        public Меню_бегуна(string email)
        {
            this.email = email; 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Регистрация_на_марафон regm = new Регистрация_на_марафон(email);
            regm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Редактирование_профиля rp = new Редактирование_профиля();
            rp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Мои_Результаты mr = new Мои_Результаты();
            mr.Show();
        }
    }
}
