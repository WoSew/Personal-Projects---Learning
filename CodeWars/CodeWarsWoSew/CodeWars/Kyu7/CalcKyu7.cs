using System.Linq;

namespace CodeWars.Kyu7
{
    public static class CalcKyu7
    {
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
    }
}