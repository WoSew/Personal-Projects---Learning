using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace WoSew.TrainingLibrary.Common.Training.Linq
{
    public static class LinqWhere
    {
        public static bool WoSewWhere()
        {
            List<string> list = new List<string>()
            {
                "andrzej",
                "konrad",
                "marcin",
                "wojtek",
                "olek",
                "slawek",
                "katarzyna"
            };

            var countWhere = list.Where(element => element.Length < 5); // zwraca element dla któego wyrażenie po lambdzie => ma dawac boola

            int test1 = countWhere.Count();

            list.Add("kuba"); // deferred execution!

            int test2 = countWhere.Count();

            return test1 != test2;

        }
    }
}