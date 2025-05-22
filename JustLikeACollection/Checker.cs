using System;
using System.Collections.Generic;
using System.Linq;

namespace JustLikeACollection
{
    public static class Checker
    {
        /// <summary>
        /// Returns the number of items in the collection that are of the specified type.
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int count = 0;
            foreach (object item in items)
            {
                if (item is T)

                    count++;

            }
            return count;
        }
    }
}
