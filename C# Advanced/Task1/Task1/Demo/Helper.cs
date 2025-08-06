using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class Helper<T> where T : IEquatable<T>
    {
        public static int LinearSearch(T[] arr , T Value)
        {
            if(arr?.Length > 0 && Value is not null)
            {
                for(int i =0;i<arr.Length;i++)
                {
                    if (Value.Equals(arr[i]))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
