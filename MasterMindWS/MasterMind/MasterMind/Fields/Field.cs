using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MasterMind.Interfaces;
using MasterMind.Properties;
using static System.ArgumentNullException;

namespace MasterMind
{
    public class Field : IField
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Color color { get; set; }

        Dictionary<Image, Color> _mastermindDictionary = new Dictionary<Image, Color>();


        public void competeDictionary()
        {
            string blackName = Resources.Black.ToString();

            Image black = Resources.Black;
            Image blue = Resources.Blue;
            Image gray = Resources.Gray;
            Image green = Resources.Green;
            Image orange = Resources.Orange;
            Image pink = Resources.Pink;
            Image red = Resources.Red;
            Image white = Resources.White;
            Image yellow = Resources.Yellow;

            _mastermindDictionary.Add(black, Color.Black);
            _mastermindDictionary.Add(blue, Color.Blue);
            _mastermindDictionary.Add(gray, Color.Gray);
            _mastermindDictionary.Add(green, Color.Green);
            _mastermindDictionary.Add(orange, Color.Orange);
            _mastermindDictionary.Add(pink, Color.Pink);
            _mastermindDictionary.Add(red, Color.Red);
            _mastermindDictionary.Add(white, Color.White);
            _mastermindDictionary.Add(yellow, Color.Yellow);


            var ressourceList = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
            var filename = ressourceList.Where(x => x.EndsWith(".png")).FirstOrDefault();


            List<Bitmap> colorList = new List<Bitmap>();

            colorList.Add(Properties.Resources.Black);
            colorList.Add(Properties.Resources.Black);
            colorList.Add(Properties.Resources.Gray);
            colorList.Add(Properties.Resources.Green);
            colorList.Add(Properties.Resources.Orange);
            colorList.Add(Properties.Resources.Pink);
            colorList.Add(Properties.Resources.Red);
            colorList.Add(Properties.Resources.White);
            colorList.Add(Properties.Resources.Yellow);

            Random rnd = new Random();

            int randomColor = rnd.Next(colorList.Count);

            Console.WriteLine(randomColor);



            {
                Console.Write("1");
            }


        }
    }
}