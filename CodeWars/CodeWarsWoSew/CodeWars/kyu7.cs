using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CodeWars
{
    public class Kyu7
    {
        public static string PrinterError(string s)
        {
            int counter =0;
            for (int i = 0; i < s.Length; i++)
            {
               if ((int) s[i] > 109)
                {
                    counter++;
                }
            }
            return counter + "/" + s.Length;
        }

        public static int NbDig(int n, int d)
        {
            int counter = 0;
            List<int> squareN = new List<int>();

            if (d == 0) counter++;
            for (int i = 0; i <= n; i++)
            {
                squareN.Add(i*i);
                
                while (squareN[i] > 0)
                {
                    int thisDigit = squareN[i] % 10; //
                    squareN[i] = squareN[i] / 10;
                    if (thisDigit == d) counter++;
                }
                
            }
            return counter;
        }

        public static int Calc(int[] array) // Operations with sequence using for loop 
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] *= array[i];
                }
                if ((i + 1) % 3 == 0)
                {
                    array[i] *= 3;
                }
                if ((i + 1) % 5 == 0)
                {
                    array[i] *= -1;
                }

            }
            return array.Sum();
        }

        public static int CalcLinq(int[] array)
        {
            return array.Select(a => a > 0 ? a * a : a)
                .Select((a, i) => (i + 1) % 3 == 0 ? 3 * a : a)
                .Select((a, i) => (i + 1) % 5 == 0 ?    -a : a)
                .Sum();
        }

        public static string[] SortByLength(string[] array)
        {
            return  array.OrderBy(s => s.Length).ToArray();
        }

        public static Dictionary<string, int> CountingArrayElements(List<string> lst)
        {
            return lst.GroupBy(s => s).ToDictionary(x => x.Key, y => y.Count());
        }

        public static int SumDigits(int number)
        {
            int sum = 0;
            if (number <0) number = -number;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}