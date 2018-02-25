using System;
using System.Linq;

namespace CodeWars.Kyu5
{
    public static class ValidParenthesesKyu5
    {
        public static bool ValidParentheses(string input)
        {
            string parentheses = "";
            int openingParenthesesQuantity = 0;
            int closingParenthesesQuantity = 0;

            foreach (var element in input)
            {
                if (element.Equals((char) 40))
                {
                    parentheses += element;
                    openingParenthesesQuantity++;
                }
                if (element.Equals((char) 41))
                {
                    parentheses += element;
                    closingParenthesesQuantity++;
                }
            }

            if (openingParenthesesQuantity != closingParenthesesQuantity)
            {
                return false;
            }

            if (parentheses.StartsWith(((char) 41).ToString()))
            {
                return false;
            }

            if (parentheses.EndsWith(((char)40).ToString()))
            {
                return false;
            }

            return true;
        }
    }
}