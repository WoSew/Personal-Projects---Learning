using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitContainer
{
    public partial class Form1 : Form
    {
        private int buttonCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddOne_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Name = "ButtonName" + buttonCounter;
            btn.Text = "ButtoTex " + buttonCounter;
            btn.Height = 30;
            btn.Width = 120;

            flowLayoutPanel2.Controls.Add(btn);
        }

        private void btn_HidePanel_1_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                splitContainer1.Panel1Collapsed = false;
                btn_HidePanel_1.Text = "Hide panel 1";
            }
            else splitContainer1.Panel1Collapsed = true;
            btn_HidePanel_1.Text = "Show panel 1";
        }

        private void btn_HidePanel_2_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                splitContainer1.Panel2Collapsed = false;
                btn_HidePanel_2.Text = "Hide panel 2";
            }
            else splitContainer1.Panel2Collapsed = true;
            btn_HidePanel_2.Text = "Show panel 2";
        }
    }
}
