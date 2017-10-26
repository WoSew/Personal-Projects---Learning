using System.Linq;

namespace WoSew.TrainingLibrary.Common.StringOperations
{
    public static class DictionarySimple
    {
        public static bool IsAnagram(this string anagramCandidate, string keyValue)
        {
            var anagramCandidateArray = anagramCandidate.ToLower().ToArray().OrderBy(s=>s);
            var keyValueArray = keyValue.ToLower().ToArray().OrderBy(s=>s);

            if (anagramCandidateArray.SequenceEqual(keyValueArray))
            {
                return true;
            }
            return false; 
        }

        public static bool IsPalindrome(this string palindromCandidate)
        {
            return palindromCandidate.Reverse().SequenceEqual(palindromCandidate);
        }

        public static bool Wildcard(this string keyValue, string wildcardCandidate)
        {
            if (wildcardCandidate.Length > keyValue.Length) return false;

            if (keyValue.Substring(0, wildcardCandidate.Length) == wildcardCandidate)
            {
                return true;
            }
            return false;
            
        }
    }
}