using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kyu6
{
    public static class UniqueInOrderKyu6
    {
        public static ICollection UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var result = new List<T>();
            foreach (var element in iterable)
            {
                if (!element.Equals(result.LastOrDefault()))
                {
                    result.Add(element);
                }
            }
            return result;
        }           
    }
}