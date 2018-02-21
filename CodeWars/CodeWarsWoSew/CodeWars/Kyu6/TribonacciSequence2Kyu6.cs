using System;

namespace CodeWars.Kyu6
{
    public static class TribonacciSequence2Kyu6
    {
        public static double[] TribonacciSequenceRefactiring(double[] signature, int n)
        {
            if (n == 0)
                return new double[] { 0.0 };

            double[] result = new double[n];

            if (n < 3)
            {
                Array.Copy(signature, result, n);
                return result;
            }

            Array.Copy(signature, result, 3);

            for (int i = 3; i < n; i++)
            {
                result[i] = result[i - 1] + result[i - 2] + result[i - 3];
            }
            return result;
        }
    }
}