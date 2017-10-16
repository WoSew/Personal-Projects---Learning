using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class kyu6
    {
        public static int Persistence(long n)
        {
            int count = 0;
            int nInt = (int) n;

            if (n.ToString().Length < 2)
            {
                return 0;
            }
            else
            {
                int result = 1;
                do
                {
                    List<int> listOfInts = new List<int>();
                    while (nInt > 0)
                    {
                        listOfInts.Add(nInt % 10);
                        nInt = nInt / 10;
                    }

                    for (int i = 0; i < listOfInts.Count; i++)
                    {
                        result *= listOfInts[i];
                    }
                    nInt = result;
                    result = 1;
                    count++;
                }
                while (nInt.ToString().Length > 1);

                return count;
            }
        }

        public static int[] Divisors(int n)
        {
            List<int> resultList = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) resultList.Add(i);
            }
            
            int[] resultInt = new int[resultList.Count];

            for (int i = 0; i < resultList.Count; i++)
            {
                resultInt[i] = resultList[i];
            }

            return resultInt;

        }
    }
}