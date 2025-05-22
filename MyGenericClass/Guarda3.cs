using System;
using System.Runtime.CompilerServices;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        // Three instance variables of type T
        private T item0;
        private T item1;
        private T item2;

        // Constructor that takes three parameters of type T
        public Guarda3()
        {
            item0 = default(T);
            item1 = default(T);
            item2 = default(T);
        }

        // Method to display the values of the instance variables
        public T GetItem(int i)
        {
            return i switch
            {
                0 => item0,
                1 => item1,
                2 => item2,
                _ => throw new ArgumentOutOfRangeException("Index must be 1, 2, or 3.")
            };
        }

        // Method to set the value of the instance variables
        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    item0 = item;
                    break;
                case 1:
                    item1 = item;
                    break;
                case 2:
                    item2 = item;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Index must be 0, 1, or 2.");
            }
        }
    }
}
