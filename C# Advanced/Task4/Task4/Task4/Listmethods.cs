using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Listmethods<T> : IEnumerable<T>
    {
        private T[] items;
        private int count;
        public Listmethods(int capacity = 4)
        {
            items = new T[capacity];
            count = 0;
        }

        public int Count => count;

        public void Add(T item)
        {
            if (count == items.Length)
                Array.Resize(ref items, items.Length * 2);
            items[count++] = item;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                items[index] = value;
            }
        }

        public bool Exists(Predicate<T> match)
        {
            for (int i = 0; i < count; i++)
                if (match(items[i])) return true;
            return false;
        }

        public T Find(Predicate<T> match)
        {
            for (int i = 0; i < count; i++)
                if (match(items[i])) return items[i];
            return default(T);
        }

        public Listmethods<T> FindAll(Predicate<T> match)
        {
            Listmethods<T> result = new Listmethods<T>();
            for (int i = 0; i < count; i++)
                if (match(items[i])) result.Add(items[i]);
            return result;
        }

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < count; i++)
                if (match(items[i])) return i;
            return -1;
        }

        public T FindLast(Predicate<T> match)
        {
            for (int i = count - 1; i >= 0; i--)
                if (match(items[i])) return items[i];
            return default(T);
        }

        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = count - 1; i >= 0; i--)
                if (match(items[i])) return i;
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < count; i++)
                action(items[i]);
        }

        public bool TrueForAll(Predicate<T> match)
        {
            for (int i = 0; i < count; i++)
                if (!match(items[i])) return false;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return items[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
