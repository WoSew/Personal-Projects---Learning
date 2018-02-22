using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kyu8
{
    public class NumberOfPeopleInTheBusKyu8
    {
        public static int NumberOfPeopleInTheBus(List<int[]> peopleListInOut)
        {
            int result = 0;

            for (int i = 0; i < peopleListInOut.Count; i++)
            {
                result += peopleListInOut[i][0] - peopleListInOut[i][1];
            }
            return result;
        }

        public static int NumberOfPeopleInTheBusLinq(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Sum(x => x[0] - x[1]);
        }  
    }
}