using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //TODO : validation data
            if (tb_name.Text != "" && tb_surname.Text != "" && tb_age.Text != "")
            {
                ListViewItem items = new ListViewItem(tb_name.Text);
                items.SubItems.Add(tb_surname.Text);
                items.SubItems.Add(tb_age.Text);

                LV_persons.Items.Add(items);

                tb_name.Text = "";
                tb_surname.Text = "";
                tb_age.Text = "";
            }
            else
                MessageBox.Show("Please fill required fields", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
              LV_persons.SelectedItems[0].Remove();
        }

        private void LV_persons_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            tb_selectedName.Text = LV_persons.SelectedItems[0].Text;
            tb_selectedSurname.Text = LV_persons.SelectedItems[0].SubItems[1].Text;
            tb_selectedAge.Text = LV_persons.SelectedItems[0].SubItems[2].Text;
        }
    }
}
