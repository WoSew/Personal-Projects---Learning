using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using MasterMind.Interfaces;
using MasterMind.Properties;
using Microsoft.SqlServer.Server;

namespace MasterMind
{
    public class MasterMindBoard : IBoard
    {
        public IField[,] Board { get; set; }

        public MasterMindBoard()
        {
            Board = new IField[10,4];

            for (int i = 0; i < Board.GetLength(0) ; i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = GetField(i, j);
                }
            }
        }

        public virtual IField GetField(int i, int j)
        {
            Field mmField = new Field();
            mmField.XCoordinate = (j * 61);
            mmField.YCoordinate = (i * 61);


            //mmField.color = _mastermindDictionary.Values;
            
            return mmField;
        }

    }
}