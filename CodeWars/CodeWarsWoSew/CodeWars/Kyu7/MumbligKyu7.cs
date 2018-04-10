using System.Linq;

namespace CodeWars.Kyu7
{
    public static class MumbligKyu7
    {
        public static string Accum(string str)
        {
            var result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += char.ToUpper(str[i]);
                
                for (int j = 0; j < i; j++)
                {
                    result += char.ToLower(str[i]);
                }

                if (i != str.Length - 1)
                {
                    result += "-";
                }
            }
            return result;
        }
    }
}