using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class FixedSizeList<T>
    {
        public int Capacity { get; }
        List<T> items;
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }
            Capacity = capacity;
            items = new List<T>(capacity);
        }
       

        public void Add(T item)
        {
            if (items.Count >= Capacity)
            {
                throw new InvalidOperationException("List is full. Cannot add more elements.");
            }
            items.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index.");
            }
            return items[index];
        }

    }
}
