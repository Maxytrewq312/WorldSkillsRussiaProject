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
    public partial class TestingForm : Form
    {
        public string email;
        public TestingForm(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Меню_бегуна mb = new Меню_бегуна(email);
            mb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin.Меню_Администратора mb = new Admin.Меню_Администратора(email);
            mb.Show();
        }
    }
}
