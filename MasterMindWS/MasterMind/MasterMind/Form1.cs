using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MasterMind
{
    public partial class Form1 : Form
    {
       
       public Form1()
        {
            InitializeComponent();
            
            MasterMindBoard mmBoard = new MasterMindBoard();
            MasterMindSecretBoard mmSecret = new MasterMindSecretBoard();
            MasterMindCheckBoard mmCheck = new MasterMindCheckBoard();

            
            
            for (int i=0;i < 10;i++)
            {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            AddCheckingButton(mmCheck,i, k ,l);
                        }
                    }
                AddRound(i);
                for (int j = 0; j < 4; j++)
                {
                    AddControl(mmBoard,i, j);
                    AddSecretFields(mmSecret, j);
                    
                }
            }        
        }
        
       public void AddRound(int i)
        {
            Button roundButton = new Button();

            roundButton.Location = new Point(Btn_Gray.Location.X, Btn_Gray.Location.Y - (i * 61)-61);
            roundButton.Size = new Size(Btn_Orange.Size.Width, Btn_Orange.Size.Height);
            roundButton.Text = (i+1).ToString();
            roundButton.TextAlign =  ContentAlignment.MiddleCenter;
            roundButton.ForeColor = Color.Black;
            roundButton.Font = new Font("Arial", 20);
            Controls.Add(roundButton);
        }

        public void AddSecretFields(MasterMindSecretBoard mmSecret, int i)
        {
            Field secretButton = new Field();

            secretButton.Location = new Point(252+mmSecret.Board[i].XCoordinate, 9);
            secretButton.Size = new Size(Btn_Orange.Size.Width, Btn_Orange.Size.Height);
            secretButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            secretButton.Text = i.ToString(); // ROBOCZO - poźniej wykomentować
            secretButton.ForeColor = Color.Black;
            
            Controls.Add(secretButton);
        }

        public void AddCheckingButton(MasterMindCheckBoard mmCheck, int i, int k, int l)
        {
            Field checkButton = new Field();

            checkButton.Location = new Point(k * 30 + Btn_Green.Location.X, l * 30 + Btn_Green.Location.Y - (i * 61)-61);
            checkButton.Size = new Size(27, 27);
            checkButton.Text = "[" + (k).ToString() + "," + (l).ToString() + "]"; // ROBOCZO - poźniej wykomentować
            checkButton.Font = new Font("Arial", 6);
            checkButton.ForeColor = Color.Black;
           

            Controls.Add(checkButton);

        }

        public void AddControl(MasterMindBoard mmBoard, int i, int j)
        {
            Field mmButton = new Field();
            

            mmButton.Location = new Point(Btn_Orange.Location.X+ mmBoard.Board[i,j].XCoordinate,Btn_Orange.Location.Y- mmBoard.Board[i,j].YCoordinate-61);       
            mmButton.Size = new Size(Btn_Orange.Size.Width, Btn_Orange.Size.Height);
            mmButton.AllowDrop = true;
            mmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Controls.Add(mmButton);
            //mmButton.Text = "["+(i).ToString()+"," + (j).ToString()+"]"; // ROBOCZO - poźniej wykomentować
            mmButton.ForeColor = Color.Black;

            mmButton.DragEnter += MmButton_DragEnter;
            mmButton.DragDrop += MmButton_DragDrop;
        }


        private void MmButton_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MmButton_DragDrop(object sender, DragEventArgs e)
        {
            Field mmButton = (Field)sender;
            
            // mmButton.SetPlayerColor(new Dictionary<Bitmap, Color>().Keys);
            //mmButton.Text =(string) e.Data.GetData(DataFormats.Text);
            mmButton.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            
        }

        
        private void bacisColor_mouseDown(object sender, MouseEventArgs e)
        {
            Button basicButton = (Button) sender;
            basicButton.Select();
            
            basicButton.DoDragDrop(basicButton.BackgroundImage, DragDropEffects.Copy);
            //basicButton.DoDragDrop(basicButton.Text, DragDropEffects.Copy);
        }
    }
}
