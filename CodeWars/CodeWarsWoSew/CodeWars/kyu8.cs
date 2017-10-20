using System.Collections.Generic;

namespace CodeWars
{
    public class Kyu8
    {
        public static long[] Digitize(long n)
        {
            var listLong = new List<long>();

            do
            {
                listLong.Add( n%10);
                n /= 10;
            } while (n !=0);

            return listLong.ToArray();

            /*            int nLength = n.ToString().Length;

            List<int> listOfInt = new List<int>();
            while (n > 0)
            {
                listOfInt.Add((int)n % 10);
                n /= 10;
            }

            long[] newLongs = new long[nLength];
            for (int i = 0; i < nLength; i++)
            {
                newLongs[i] = listOfInt[i];
            }

            return newLongs;*/

        }

        public static string Remove_char(string s)
        {
            string result = "";
            for (int i = 1; i < s.Length-1; i++)
            {
                result += s[i];
            }
            return result;

            //-----second solution-----
            //return s.Substring(1,(s.Length - 2));
        }

    }
}
 