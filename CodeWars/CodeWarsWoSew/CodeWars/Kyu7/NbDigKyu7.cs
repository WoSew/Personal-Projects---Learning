using System.Collections.Generic;

namespace CodeWars.Kyu7
{
    public static class NbDigKyu7
    {
        public static int NbDig(int n, int d)
        {
            int counter = 0;
            List<int> squareN = new List<int>();

            if (d == 0) counter++;
            for (int i = 0; i <= n; i++)
            {
                squareN.Add(i * i);

                while (squareN[i] > 0)
                {
                    int thisDigit = squareN[i] % 10; //
                    squareN[i] = squareN[i] / 10;
                    if (thisDigit == d) counter++;
                }
            }
            return counter;
        }
    }
}