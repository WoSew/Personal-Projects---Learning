namespace CodeWars.Kyu7
{
    public static class SumDigitsKyu7
    {
        public static int SumDigits(int number)
        {
            int sum = 0;
            if (number < 0) number = -number;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}