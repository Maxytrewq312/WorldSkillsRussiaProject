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
    public partial class Подтверждение : Form
    {
        public Подтверждение(int s, string s1)
        {
            InitializeComponent();
            label3.Text = Convert.ToString("$" + s);
            label4.Text = Convert.ToString(s1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Подтверждение_Load(object sender, EventArgs e)
        {

        }
    }
}
