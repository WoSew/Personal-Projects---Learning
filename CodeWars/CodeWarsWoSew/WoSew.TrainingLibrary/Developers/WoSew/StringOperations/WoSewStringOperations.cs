using System.Collections.Generic;
using WoSew.TrainingLibrary.Common.Base.Inheritance;
using WoSew.TrainingLibrary.Common.StringOperations;

namespace WoSew.TrainingLibrary.Developers.WoSew.StringOperations
{
    public class WoSewStringOperations<T> : StringDictionary<T>
    {
        public override List<T> GetAnagramSet(string anagramCandidate)
        {
            List<T> itemList = new List<T>();

            foreach (var item in this)
            {
                if (item.Key.IsAnagram(anagramCandidate))
                {
                    itemList.Add(this[item.Key]);
                }
            }
            return itemList;
        }

        public override List<T> GetPalindromSet()
        {
            List<T> itemList = new List<T>();

            foreach (var item in this)
            {
                if (item.Key.IsPalindrome())
                {
                    itemList.Add(this[item.Key]);
                }
            }
            return itemList;
        }

        public override List<T> GetWildcardSet(string wildcard)
        {
            List<T> itemList = new List<T>();

            foreach (var item in this)
            {
                if (item.Key.Wildcard(wildcard))
                {
                    itemList.Add(this[item.Key]);
                }
            }
            return itemList;
        }
    }
}