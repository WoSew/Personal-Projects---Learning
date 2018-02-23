using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kyu7
{
    public static class LoveVsFriendshipKyu7
    {
        public static int LoveVsFriendship(string str)
        {
            var stringLower = str.ToLowerInvariant();
            int sum = 0;

            Dictionary<char, int> alphabet = new Dictionary< char, int> ();

            for (int i = 1; i <= 26; i++)
            {
                alphabet.Add((char)(96+i), i);
            }
            
            foreach (var i in stringLower)
            {
                if (alphabet.ContainsKey((char)i))
                {
                    sum += alphabet[i];
                }
            }          
            return sum;
        }

        public static int LoveVeFriendshipLinq(string str)
            => str.Sum(x => x - 96);
    }
}