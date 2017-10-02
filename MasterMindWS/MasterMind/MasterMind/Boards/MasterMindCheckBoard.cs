using MasterMind.Interfaces;

namespace MasterMind
{
    public class MasterMindCheckBoard : IBoard
    {
        public IField[,] Board { get; set; }

        public MasterMindCheckBoard()
        {
            Board = new IField[2,2];
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = GetField(i, j);
                }
            }
        }

        public virtual IField GetField(int i, int j)
        {
            CheckField mmCheckField = new CheckField();
            mmCheckField.XCoordinate = i * 30;
            mmCheckField.YCoordinate = i* 30;

            return mmCheckField;
        }
    }
}