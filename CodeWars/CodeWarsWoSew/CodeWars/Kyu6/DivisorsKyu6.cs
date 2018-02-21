using System.Collections.Generic;

namespace CodeWars.Kyu6
{
    public static class DivisorsKyu6
    {
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