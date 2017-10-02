using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MasterMind
{
    public partial class Form1 : Form
    {
        public int RoundCounter = 1;
        public Form1()
        {
            InitializeComponent();
            
            //ADD buttons
            for (int i=1;i < 11;i++)
            {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            AddCheckingButton(i, k ,l);
                        }
                    }
                AddRound(i);
                for (int j = 0; j < 4; j++)
                {
                    AddControl(i, j);
                }
            }
            
        }
        
        public void AddRound(int i)
        {
            Button roundButton = new Button();

            roundButton.Location = new Point(Btn_Gray.Location.X, Btn_Gray.Location.Y - (i * 61));
            roundButton.Size = new Size(Btn_Orange.Size.Width, Btn_Orange.Size.Height);
            roundButton.Text = i.ToString();
            roundButton.TextAlign =  ContentAlignment.MiddleCenter;
            roundButton.ForeColor = Color.Black;
            roundButton.Font = new Font("Arial", 20);
            Controls.Add(roundButton);
        }

        public void AddCheckingButton(int i, int k, int l)
        {
            Button checkButton = new Button();

            checkButton.Location = new Point(k * 30 + Btn_Green.Location.X, l * 30 + Btn_Green.Location.Y - (i * 61));
            checkButton.Size = new Size(27, 27);
            Controls.Add(checkButton);
        }

        public void AddControl(int i, int j)
        {
            Button mmButton = new Button();
            mmButton.Location = new Point(Btn_Orange.Location.X+(j*61), Btn_Orange.Location.Y -(i*61));
            mmButton.Size = new Size(Btn_Orange.Size.Width, Btn_Orange.Size.Height);
            mmButton.AllowDrop = true;
            mmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Controls.Add(mmButton);

            mmButton.DragEnter += MmButton_DragEnter;
            mmButton.DragDrop += MmButton_DragDrop;
        }


        private void MmButton_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MmButton_DragDrop(object sender, DragEventArgs e)
        {
            Button mmButton = (Button)sender;
            mmButton.BackgroundImage = (Bitmap) e.Data.GetData(DataFormats.Bitmap);
        }
        
        private void bacisColor_mouseDown(object sender, MouseEventArgs e)
        {
            Button basicButton = (Button) sender;
            basicButton.Select();
            basicButton.DoDragDrop(basicButton.BackgroundImage, DragDropEffects.Copy);
        }
    }
}
