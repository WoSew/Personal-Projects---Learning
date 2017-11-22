using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "GReetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_hello_MouseEnter(object sender, EventArgs e)
        {
            Tooltip_Cloud.ToolTipIcon = ToolTipIcon.Info;
            Tooltip_Cloud.ToolTipTitle = "Tooltip title";
            Tooltip_Cloud.SetToolTip(btn_hello, "Here is cloud from tooltip control");
        }
    }
}
