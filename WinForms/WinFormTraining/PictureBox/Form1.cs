using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PictureBox.Properties;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        private List<Image> ListOfPictures;
        private int IdPicture = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb_photos.Image = Resources.defaultPhotojpg;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (ListOfPictures == null)
            {
                ListOfPictures = new List<Image>();

                MessageBox.Show("Loading list of elements...\nPlease wait.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListOfPictures.Add(Image.FromFile(@"c:\Users\wojse\Pictures\1.jpg"));
                ListOfPictures.Add(Image.FromFile(@"c:\Users\wojse\Pictures\2.jpg"));
                ListOfPictures.Add(Image.FromFile(@"c:\Users\wojse\Pictures\3.jpg"));
                ListOfPictures.Add(Image.FromFile(@"c:\Users\wojse\Pictures\4.jpg"));

                MessageBox.Show("List of items has been loaded.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("List of items is already loaded.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdPicture > 0)
                    IdPicture--;
                else IdPicture = ListOfPictures.Count - 1;

                pb_photos.Image = ListOfPictures[IdPicture];
                lb_id.Text = "ID: " + IdPicture;
            }
            catch
            {
                DialogResult result = MessageBox.Show("No photos uploaded. Do you want to load a list of photos?", "Question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) btn_load_Click(sender, e);

            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                IdPicture++;
                if (IdPicture > ListOfPictures.Count - 1)
                    IdPicture = 0;

                pb_photos.Image = ListOfPictures[IdPicture];
                lb_id.Text = "ID: " + IdPicture;
            }
            catch
            {
                DialogResult result = MessageBox.Show("No photos uploaded. Do you want to load a list of photos?", "Question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) btn_load_Click(sender, e);
            }

        }

        private void pb_photos_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pb_photos.Image = Image.FromFile(file.FileName);
            }
        }
    }
}
