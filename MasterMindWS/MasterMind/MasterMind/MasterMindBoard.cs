using MasterMind.Interfaces;

namespace MasterMind
{
    public class MasterMindBoard : IBoard
    {
        public IField[,] Board { get; set; }

        public MasterMindBoard() //konstruktor
        {
            Board = new IField[4,10];


        }
    }
}