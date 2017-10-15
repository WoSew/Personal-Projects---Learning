using System.Collections.Generic;
using System.Drawing;
using MasterMind.Interfaces;

namespace MasterMind
{
    public class CheckField : IField
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Color Color { get; set; }
    }
}