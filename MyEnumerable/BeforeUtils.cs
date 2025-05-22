using System;
using System.Collections.Generic;

namespace MyEnumerable
{
    public static class BeforeUtils
    {
        /// <summary>
        /// Returns an enumerable of items that are less than the specified threshold.
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T threshold)
            where T : struct, IComparable<T>
        {
            foreach (T item in items)
            {
                if (item.CompareTo(threshold) < 0)
                {
                    yield return item;
                }
            }
        }
    }
}
