using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
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
                throw new IndexOutOfRangeException();
            return items[i];
        }

        // Method to set the value of the instance variables
        public void SetItem(int i, T item)
        {
            if (i < 0 || i >= 3)
                throw new IndexOutOfRangeException();
            items[i] = item;
        }
        
        // Method to add an item to the first empty slot
        public void Add(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], default(T)))
                {
                    items[i] = item;
                    return;
                }
            }
            throw new InvalidOperationException("No empty slots available.");
        }

        // Implementation of generic IEnumerator
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        // Explicit interface implementation for non-generic IEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
