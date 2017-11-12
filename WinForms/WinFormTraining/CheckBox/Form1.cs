using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_1.Checked)
            {
                this.BackColor = Color.Aqua;
                cb_1.Text = "Cancel";
            }
            else
            {
                this.BackColor = Color.Brown;
                cb_1.Text = "Ok";
            }
        }
    }
}
