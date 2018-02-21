using System.Linq;

namespace CodeWars.Kyu7
{
    public class CalcLinqKyu7
    {
        public static int CalcLinq(int[] array)
        {
            return array.Select(a => a > 0 ? a * a : a)
                .Select((a, i) => (i + 1) % 3 == 0 ? 3 * a : a)
                .Select((a, i) => (i + 1) % 5 == 0 ? -a : a)
                .Sum();
        }
    }
}