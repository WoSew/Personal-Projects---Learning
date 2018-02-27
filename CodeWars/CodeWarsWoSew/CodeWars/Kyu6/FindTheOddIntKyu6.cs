using System.Linq;

namespace CodeWars.Kyu6
{
    public static class FindTheOddIntKyu6
    {
        public static int FindTheOddInt(int[] seq)
        {
            var dict =  seq.GroupBy(s => s).ToDictionary(x => x.Key, y => y.Count());
          
            var max = dict.Where(x=> (x.Value % 2) != 0).Max(x => x.Value);

            var result = dict.Where(x => x.Value == max).Select(x => x.Key).First();
            return result;
        }
    }
}