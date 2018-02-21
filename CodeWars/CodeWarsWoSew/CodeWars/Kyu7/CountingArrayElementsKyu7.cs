using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kyu7
{
    public class CountingArrayElementsKyu7
    {
        public static Dictionary<string, int> CountingArrayElements(List<string> lst)
        {
            return lst.GroupBy(s => s).ToDictionary(x => x.Key, y => y.Count());
        }
    }
}