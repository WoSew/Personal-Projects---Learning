using System.Drawing;

namespace MasterMind.Interfaces
{
    public interface IField
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
        Color Color { get; set; }
        void GetPlayerColor();
    }
}