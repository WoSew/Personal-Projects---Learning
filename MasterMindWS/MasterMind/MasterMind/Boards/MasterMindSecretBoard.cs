using MasterMind.Interfaces;

namespace MasterMind
{
    public class MasterMindSecretBoard : ISecretBoard
    {
        public IField[] Board { get; set; }

        public MasterMindSecretBoard()
        {
            Board = new IField[4];

            for (int i = 0; i < Board.Length; i++)
            {
                Board[i] = GetField(i);
            }
        }

        public virtual IField GetField(int i)
        {
            SecretField mmSecretField = new SecretField();
            mmSecretField.XCoordinate = i * 61;

           // mmSecretField.color
            return mmSecretField;
        }
    }
}