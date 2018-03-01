using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars.Kyu6
{
    public static class YourOrderPleaseKyu6
    {
        public static string YourOrderPlease(string words)
        {
            if (words != null)
            {
                var splitWords = words.Split();

                Dictionary<string, string> splitDictionary = new Dictionary<string, string>();

                foreach (var element in splitWords)
                {
                    var resultNumber = Regex.Match(element, @"\d+").Value;
                    splitDictionary.Add(resultNumber, element);
                }

                var orderedDictionary = splitDictionary.OrderBy(x => x.Key);
                string result = "";

                foreach (var element in orderedDictionary)
                {
                    result += element.Value + " ";
                }
                
                return result.TrimEnd();
            }
            return null;
        }

        public static string YourOrderPleaseLinq(string words)
        {
            return string.Join(" ", words.Split().OrderBy(x => x.SingleOrDefault(char.IsDigit)));
        }

    }
}