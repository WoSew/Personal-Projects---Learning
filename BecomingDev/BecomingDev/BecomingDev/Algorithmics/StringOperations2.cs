using System;
using System.Collections.Generic;
using System.Linq;

namespace BecomingDev.Algorithmics
{
    public static class StringOperations2
    {
        public static string ReverseString(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        public static string ReverseString2(string str)
        {
            var result = "";
            for (int i = str.Length-1; i >=0 ; i--)
            {
                result += str[i];
            }
            return result;
        }

        public static bool IsPalindrom(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Invalid string");
            }

            string palindromCandidate = str.Replace(" ", "").ToLower();

            var palindromCandidateReverse = new string(palindromCandidate.Reverse().ToArray());

            if (palindromCandidate == palindromCandidateReverse)
            {
                return true;
            }
            return false;
        }

        public static bool IsAnagram(string str1, string str2)
        {
            var a = string.Concat(str1.Replace(" ", "").ToLower().OrderBy(x => x));
            var b = string.Concat(str2.Replace(" ", "").ToLower().OrderBy(x => x));

            return a == b;
        }

        public static string Substring(string str, int start, int length)
        {
            var result = "";
            for (int i = start; i < start+length && i < str.Length; i++)
            {
                result += str[i];
            }
            return result;
        }

        public static int PowerInt(int number)
        {
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            
            }
            return result;

        }

        public static int[] bubbleSort(int[] arrayOfInts)
        {
            int length = arrayOfInts.Length;
            int temp;

            for (int i = 0; i < length; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    if (arrayOfInts[i] > arrayOfInts[j])
                    {
                        temp = arrayOfInts[i];
                        arrayOfInts[i] = arrayOfInts[j];
                        arrayOfInts[j] = temp;
                    }
                }
            }
            return arrayOfInts;
        }

        public static Dictionary<string, int> WordCounts(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Invalid string.");
            }
            
            var stringHelper = str.Split();
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();

            foreach (var item in stringHelper)
            {
                if (resultDictionary.ContainsKey(item))
                {
                    resultDictionary[item]++;
                }
                else
                {
                    resultDictionary.Add(item, 1);
                }
            }
            return resultDictionary;
        }

    }
}