using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kyu6
{
    public static class GarbleSortKyu6
    {
        public static int[] GarbleSort(int[] values)
        {
            const string order = "796413582";
            var resultOrdered = values.OrderBy(x => order.IndexOf(x.ToString()));

            return resultOrdered.ToArray();
        }
    }
}