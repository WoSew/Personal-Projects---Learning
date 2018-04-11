using System;
using System.Linq;

namespace CodeWars.Kyu5
{
    public static class ConvertStringToCamelCaseKyu5
    {
        public static string ToCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            var splitedString = str.Replace("-", " ").Replace("_", " ").Split();
            var result = "";

            if (char.IsLower(splitedString[0][0]))
            {
                result += splitedString[0];
            }
            else
            {
                result += splitedString[0].First().ToString().ToUpper() + String.Join("", splitedString[0].Skip(1));
            }
          
            for (int i = 1 ; i < splitedString.Length; i++)
            {
                result += splitedString[i].First().ToString().ToUpper() + String.Join("", splitedString[i].Skip(1));
            }
            return result;
        }
    }
}