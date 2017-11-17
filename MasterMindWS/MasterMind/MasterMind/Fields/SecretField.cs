using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MasterMind.Interfaces;

namespace MasterMind
{
    public class SecretField : IField
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Color Color { get; set; }
        public void GetPlayerColor()
        {
            throw new NotImplementedException();
        }

        /*
        public void randomIMG(int i)
        {
            SecretField secretField = new SecretField();
            Random rnd = new Random();
            int randomNumber = rnd.Next(8);

            switch (randomNumber)
            {
                case 0:
                    secretField.BackgroundImage = global::MasterMind.Properties.Resources.Black;
                    break;
                case 1:
                    secretField.BackgroundImage = global::MasterMind.Properties.Resources.Blue;
                    break;
                case 2:
                    secretField.BackgroundImage = global::MasterMind.Properties.Resources.Gray;
                    break;
                case 3:
                    secretField.BackgroundImage = global::MasterMind.Properties.Resources.Green;
                    break;
                case 4:
                    secretField.BackgroundImage = global::MasterMind.Properties.Resources.Orange;
                    break;
                case 5:
                    secretField.BackgroundImage = global::MasterMind.Properties.Resources.Pink;
                    break;
                case 6:
                    secretField.BackgroundImage = global::MasterMind.Properties.Resources.Red;
                    break;
                case 7:
                    secretField.BackgroundImage = global::MasterMind.Properties.Resources.Yellow;
                    break;
                default:
                    break;
            }
            
        }
        */

    }
}