using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool compareDelegate<A>(A a, A b);
    internal class SortingAlgorithms<T>
    {
        public static void BubbleSort(T[] arr, compareDelegate<T> compare)
        {
            if(arr is not null)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    for(int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (compare.Invoke(arr[j], arr[j + 1]))
                        {
                            swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }

        static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
