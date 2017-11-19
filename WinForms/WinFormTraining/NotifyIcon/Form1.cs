using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_showNotyfication_Click(object sender, EventArgs e)
        {
            notifyIcon_1.Icon = SystemIcons.Information;
            notifyIcon_1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon_1.BalloonTipTitle = "Notyfication title by WoSew";
            notifyIcon_1.BalloonTipText = "Example notyfication content.";
            notifyIcon_1.ShowBalloonTip(1000);
        }
    }
}
