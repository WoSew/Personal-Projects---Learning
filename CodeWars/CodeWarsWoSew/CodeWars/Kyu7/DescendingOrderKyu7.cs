using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kyu7
{
    public static class DescendingOrderKyu7
    {
        public static int DescendingOrder(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            List<int> listOfDigits = new List<int>();
            while (number > 0)
            {
                listOfDigits.Add(number%10);
                number = number / 10;
            }

            var orderedList = listOfDigits.OrderByDescending(x => x);

            int result = int.Parse(string.Join("", orderedList)); 

            return result;
        }
    }
}