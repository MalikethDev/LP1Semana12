using System;
using System.Collections.Generic;
using System.Linq;

namespace HowManyOfThisType
{
    public static class Checker
    {
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
