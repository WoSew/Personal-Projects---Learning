using System.Linq;

namespace CodeWars.Kyu7
{
    public static class SortByLengthKyu7
    {
        public static string[] SortByLength(string[] array)
        {
            return array.OrderBy(s => s.Length).ToArray();
        }
    }
}