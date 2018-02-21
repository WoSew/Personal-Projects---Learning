namespace CodeWars.Kyu7
{
    public static class PrinterErrorKyu7
    {
        public static string PrinterError(string s)
        {
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] > 109)
                {
                    counter++;
                }
            }
            return counter + "/" + s.Length;
        }
    }
}