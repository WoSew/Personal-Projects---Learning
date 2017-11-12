using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clb_1.CheckOnClick = true; // 1 click to checked position
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clb_1.Items.Add("Added position");
        }

        private void clb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtb_1.Text = "";
            foreach (var value in clb_1.CheckedItems)
            {
                rtb_1.Text += value + ", ";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            clb_1.Items.Add(textBox_add.Text);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (clb_1.Items.Contains(textBox_del.Text))
            {
                clb_1.Items.Remove(textBox_del.Text);
            }
            else
            {
                MessageBox.Show("Current value doesn't exist");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
