using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class Kyu6
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

        public static double[] TribonacciSequence(double[] signature, int n)
        {
            switch (n)
            {
                case 0:
                {
                    double[] result = new double[1];
                    result[n] = 0;
                    return result;
                }

                case 1:
                {
                    double[] result = new double[1];
                    result[0] = signature[0];
                    return result;
                }

                case 2:
                {
                    double[] result = new double[2];
                    for (int i = 0; i < n; i++)
                    {
                        result[i] = signature[i];
                    }
                    return result;
                }

                case 3:
                {
                    double[] result = new double[3];
                    for (int i = 0; i < n; i++)
                    {
                        result[i] = signature[i];
                    }
                        return result;
                }

                default:
                {
                    double[] result = new double[n];
                    for (int i = 0; i < 3; i++)
                    {
                        result[i] = signature[i];
                    }

                    for (int i = 3; i < n; i++)
                    {

                        result[i] = result[i - 1] + result[i - 2] + result[i - 3];
                    }
                    return result;
                }
            }
       
        }

        public static double[] TribonacciSequenceRefactiring(double[] signature, int n)
        {
            if (n == 0)
            return new double[] {0.0};

            double[] result = new double[n];

            if (n < 3)
            {
                Array.Copy(signature,result,n);
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