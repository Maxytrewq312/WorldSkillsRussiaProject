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
    }
}
