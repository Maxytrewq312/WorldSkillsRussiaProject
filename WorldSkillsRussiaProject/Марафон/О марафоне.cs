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
    }
}
