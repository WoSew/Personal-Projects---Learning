namespace CodeWars.Kyu7
{
    public static class GetTheMiddleCharacterKyu7
    {
        public static string GetMiddle(string str)
        {
            var length = str.Length;
            if (length % 2 == 0)
            {
                return str.Substring(length / 2 - 1, 2);
            }
            return str.Substring((length-1) / 2, 1);
        }
    }
}