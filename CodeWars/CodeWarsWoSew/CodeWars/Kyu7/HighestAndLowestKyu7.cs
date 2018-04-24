using System;
using System.Linq;

namespace CodeWars.Kyu7
{
    public static class HighestAndLowestKyu7
    {
        public static string HighAndLow(string numbers)
        {
            int[] arrayInts = Array.ConvertAll(numbers.Split(), x => int.Parse(x));

            string result = arrayInts.Max().ToString() +" "+ arrayInts.Min().ToString();

            return result;
        }
    }
}