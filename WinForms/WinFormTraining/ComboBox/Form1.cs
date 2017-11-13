using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (cb_Crypto.Items.Contains(tb_add.Text))
            {
                MessageBox.Show(tb_add.Text + "Already exist", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(tb_add.Text + " was added to list.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cb_Crypto.Items.Add(tb_add.Text);
            }
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            if (cb_Crypto.Items.Contains(tb_del.Text))
            {
                MessageBox.Show("Deletion is in progress: " + tb_del.Text + ". Please wait...", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Crypto.Items.Remove(tb_del.Text);
            }
            else
            {
                MessageBox.Show("Item: " + tb_del.Text + " not found", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Btn_ins_Click(object sender, EventArgs e)
        {
            if (cb_Crypto.SelectedIndex != -1)
            {
                if (!cb_Crypto.Items.Contains(tb_ins.Text))
                {
                    cb_Crypto.Items.Insert((cb_Crypto.SelectedIndex + 1), tb_ins.Text);
                }
                else
                    MessageBox.Show(tb_ins.Text + " already exist.", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else MessageBox.Show("Select an item.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
