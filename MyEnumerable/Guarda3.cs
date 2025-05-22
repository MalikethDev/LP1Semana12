using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace MyGenericClass
{
    public class Guarda3<T> : IEnumerable
    {
        // Three instance variables of type T
        private T[] items;

        // Constructor that takes three parameters of type T
        public Guarda3()
        {
            items = new T[3]; // Initializes with default(T)
        }

        // Method to display the values of the instance variables
        public T GetItem(int i)
        {
            if (i < 0 || i >= 3)
                throw new ArgumentOutOfRangeException("Index must be 0, 1, or 2.");
            return items[i];
        }

        // Method to set the value of the instance variables
        public void SetItem(int i, T item)
        {
            if (i < 0 || i >= 3)
                throw new ArgumentOutOfRangeException("Index must be 0, 1, or 2.");
            items[i] = item;
        }

        // Implementation of generic IEnumerator
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }
    }
}
