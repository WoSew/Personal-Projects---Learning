using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kyu7
{
    public static class SumOfArraySinglesKyu7
    {
        public static int SumOfArraySingles(List<int> source)
        {
            var result = source.GroupBy(x => x).Where(x => x.Count() == 1).Sum( x => x.Key);

            //var result = source.Where(x => source.Count(y => x == y) == 1).Sum();
            return result;
        }
    }
}