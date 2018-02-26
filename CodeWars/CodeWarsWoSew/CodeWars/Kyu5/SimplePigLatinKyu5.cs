using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kyu5
{
    public static class SimplePigLatinKyu5
    {
        public static string SimplePigLatin(string str)
        {
            //var punctuation = str.Where(Char.IsPunctuation).Distinct().ToArray();
            var listOfWords = str.Split().Select(x => x);
            List<string> result = new List<string>();

            foreach (var element in listOfWords)
            {
                result.Add(element.Substring(1, element.Length - 1)
                           + element.Substring(0, 1)
                           + "ay");
            }

            var resultString = String.Join(" ", result.ToArray());

            return resultString;
        }
    }
}