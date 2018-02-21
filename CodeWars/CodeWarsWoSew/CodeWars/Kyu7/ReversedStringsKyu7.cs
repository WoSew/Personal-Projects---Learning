using System.Linq;

namespace CodeWars.Kyu7
{
    public static class ReversedStringsKyu7
    {
        public static string ReversedStringsLinq(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }

        public static string ReversedStringsLoop(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }

    }
}