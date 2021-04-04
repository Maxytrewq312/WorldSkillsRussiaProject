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
    public partial class Контакты : Form
    {
        public Контакты()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
