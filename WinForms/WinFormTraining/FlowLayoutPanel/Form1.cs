using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowLayoutPanel
{
    public partial class Form1 : Form
    {
        private int buttonCounter = 0;

        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddButton_Click(object sender, EventArgs e)
        {
            Button btnButton = new Button();
            btnButton.Name = tb_btnName.Text + buttonCounter++;
            btnButton.Text = tb_btnText.Text +" "+ buttonCounter;
            btnButton.Width = 100;
            btnButton.Height = 30;
            flp_Panel.Controls.Add(btnButton);

            counter = buttonCounter + 1;
            btn_AddButton.Text = "Add" + counter + " button";
        }

        private void btn_AddButtons_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nud_Quantity.Value; i++)
            {
                Button btnButton = new Button();
                btnButton.Name = tb_btnName.Text + buttonCounter++;
                btnButton.Text = tb_btnText.Text + " " + buttonCounter;
                btnButton.Width = 100;
                btnButton.Height = 30;
                flp_Panel.Controls.Add(btnButton);
            }
        }

        private void nud_Quantity_ValueChanged(object sender, EventArgs e)
        {
            btn_AddButtons.Text = "Add " + nud_Quantity.Value + " buttons";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Alignment.SelectedIndex = 0;
        }

        private void cb_Alignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_Alignment.Text)
            {
                case "TopDown":
                    {
                        flp_Panel.FlowDirection = FlowDirection.TopDown;
                    }break;

                case "ButtomUp":
                    {
                        flp_Panel.FlowDirection = FlowDirection.BottomUp;
                    }break;

                case "LeftToRight":
                    {
                        flp_Panel.FlowDirection = FlowDirection.LeftToRight;
                    }break;

                case "RightToLeft":
                    {
                        flp_Panel.FlowDirection = FlowDirection.RightToLeft;
                    }break;
            }
        }

        private void clb_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (clb_Properties.SelectedIndex)
            {
                case 0:
                {
                    if (clb_Properties.GetItemChecked(0))
                        {
                            flp_Panel.AutoScroll = true;
                        }
                        else flp_Panel.AutoScroll = false;
                }break;

                case 1:
                {
                    if (clb_Properties.GetItemChecked(1))
                        {
                            flp_Panel.AutoSize = true;
                        }
                        else flp_Panel.AutoSize= false;
                    }break;

                case 2:
                {
                    if (clb_Properties.GetItemChecked(2))
                        {
                            flp_Panel.WrapContents = true;
                        }
                        else flp_Panel.WrapContents = false;
                    }break;
            }
        }

    }
}
