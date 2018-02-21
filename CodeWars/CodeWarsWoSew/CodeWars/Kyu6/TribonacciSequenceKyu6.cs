namespace CodeWars.Kyu6
{
    public static class TribonacciSequenceKyu6
    {
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
    }
}