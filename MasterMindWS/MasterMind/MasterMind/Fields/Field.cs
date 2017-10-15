using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MasterMind.Interfaces;
using MasterMind.Properties;

namespace MasterMind
{
    public class Field : Button, IField
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Color Color { get; set; }
        
        Dictionary<Bitmap, Color> _mastermindDictionary = new Dictionary<Bitmap, Color>();

        public void GetPlayerColor()
        {
            Bitmap black = Resources.Black;
            Bitmap blue = Resources.Blue;
            Bitmap gray = Resources.Gray;
            Bitmap green = Resources.Green;
            Bitmap orange = Resources.Orange;
            Bitmap pink = Resources.Pink;
            Bitmap red = Resources.Red;
            Bitmap white = Resources.White;
            Bitmap yellow = Resources.Yellow;

            _mastermindDictionary.Add(black, Color.Black);
            _mastermindDictionary.Add(blue, Color.Blue);
            _mastermindDictionary.Add(gray, Color.Gray);
            _mastermindDictionary.Add(green, Color.Green);
            _mastermindDictionary.Add(orange, Color.Orange);
            _mastermindDictionary.Add(pink, Color.Pink);
            _mastermindDictionary.Add(red, Color.Red);
            _mastermindDictionary.Add(white, Color.White);
            _mastermindDictionary.Add(yellow, Color.Yellow);




        }

       
    }
}