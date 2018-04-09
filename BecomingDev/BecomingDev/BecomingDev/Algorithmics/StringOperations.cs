using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace BecomingDev.Algorithmics
{
    public static class StringOperations
    {
        public static string ReverseString(string str)
        {
            var result = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }

        public static string ReverseString2(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        public static bool IsPalindrom(string stringCandidate)
        {
            if (string.IsNullOrEmpty(stringCandidate))
            {
                throw new Exception("Invalid string");
            }

            string palindromCandidate =  stringCandidate.Replace(" ", "").ToLower();
            var length = palindromCandidate.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (palindromCandidate[i] != palindromCandidate[length-i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsAnagram(string str1, string str2)
        {
            var a = String.Concat(str1.Replace(" ", "").OrderBy(x => x));
            var b = String.Concat(str2.Replace(" ", "").OrderBy(x => x));

            return a == b;
        }

        public static string SubString(string str, int start, int end)
        {
            string result = "";

            for (int i = start; i < start+end && i < str.Length; i++)
            {
                result += str[i];
            }
            return result;
        }

        public static int PowerOfInt(int number)
        {
            int result = 1;

            for (int i = 1; i < number; i++)
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
    }
}