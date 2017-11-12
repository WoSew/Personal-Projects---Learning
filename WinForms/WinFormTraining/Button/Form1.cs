using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BackColor = Color.Aqua;
        }

        private void btn_1_Enter(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.Brown;
            btn_1.ForeColor = Color.AliceBlue;
        }

        private void btn_1_Leave(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.GreenYellow;
            btn_1.ForeColor = Color.DarkOrchid;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is message box from button 2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BackColor = Color.BurlyWood;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
