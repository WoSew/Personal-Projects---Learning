namespace CodeWars.Kyu7
{
    public static class StringEndsWithKyu7
    {
        public static bool StringEndWith(string str, string ending)
        {
            if (str.Length == ending.Length)
            {
                if (str == ending)
                {
                    return true;
                }
            }

            if (str.Length > ending.Length)
            {
                var substring = str.Substring(str.Length - ending.Length, ending.Length);
                if (substring == ending)
                {
                    return true;
                }       
            }          
            return false;
        }

        public static bool StringEndWithSecond(string str, string ending)
        {
            return str.EndsWith(ending);
        }
    }
}