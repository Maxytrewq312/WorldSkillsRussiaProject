using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkillsRussiaProject.Бегун
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        private string _name;
        private string _amount;

        public string NameLabel
        {
            get { return _name; }
            set { _name = value; nameLabel.Text = value; }
        }

        public string Amount
        {
            get { return _amount; }
            set { _amount = value; moneyLabel.Text = value; }
        }
    }
}
