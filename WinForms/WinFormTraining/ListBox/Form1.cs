using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!lb_valueList.Items.Contains(rtb_new.Text))
            {
                if (rtb_new.Text != "")
                {
                    lb_valueList.Items.Add(rtb_new.Text);
                    rtb_new.Text = "";
                }
                else MessageBox.Show("Please enter new value.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Value: " + rtb_new.Text + "  already exist.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (rtb_del.Text != "")
            {
                lb_valueList.Items.Remove(rtb_del.Text);
            }
            if (lb_valueList.SelectedIndex != -1)
            {
                lb_valueList.Items.Remove(lb_valueList.SelectedItem);
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            lb_valueList.Sorted = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lb_valueList.Items.Clear();
        }
        
        private void lb_selected_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
         
        }

        private void lb_valueList_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void lb_valueList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                lb_valueList.Items.Add(file);
            }
        }

        private void lb_valueList_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb_valueList.Items.Count == 0)
                return;
            int index = lb_valueList.IndexFromPoint(e.X, e.Y);
            string s = lb_valueList.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
            {
                lb_valueList.Items.RemoveAt(lb_valueList.IndexFromPoint(e.X,e.Y));
            }
        }
        
        private void lb_selected_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        

        private void lb_selected_DragDrop(object sender, DragEventArgs e)
        {
            //copy path of file
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    lb_selected.Items.Add(file);
                }
            }

            //copy object from another control 
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string) e.Data.GetData(DataFormats.StringFormat);

                lb_selected.Items.Add(str);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            var filePath = lb_selected.SelectedItem.ToString();
            if(File.Exists(filePath))
            {
                Process.Start("explorer.exe", filePath);
            }
        }

        private void lb_selected_DoubleClick(object sender, EventArgs e)
        {
            var filePath = lb_selected.SelectedItem.ToString();
            if (File.Exists(filePath))
            {
                Process.Start("explorer.exe", filePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filePath = lb_selected.SelectedItem.ToString();
            if (File.Exists(filePath))
            {
                Process.Start("explorer.exe", "/select, " + filePath);
            }
        }
    }
}
