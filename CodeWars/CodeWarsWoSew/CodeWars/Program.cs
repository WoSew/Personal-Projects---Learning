using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoSew.TrainingLibrary.Test.Common.Training.Exceptions;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            WoSewExceptions wsExceptions = new WoSewExceptions();
            wsExceptions.SelectiveExceptions();
            wsExceptions.TryCatchFinally();
            wsExceptions.TryCatchFinallyException();


            Kyu7.Calc(new[] { -2, -1, 0, 1, 2 });
            Kyu7.NbDig(25, 0);
            Kyu6.Divisors(16);
            Kyu8.Remove_char("eloquent");
            Kyu6.Persistence(39);

        }
    }
}
