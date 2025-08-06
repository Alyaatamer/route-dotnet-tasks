using System.Numerics;

namespace Task1
{
    public class Range<T> where T : IComparable<T> , INumber<T>
    {
        public T min {  get; }
        public T max {  get; }

        public Range(T min, T max)
        {
            this.min = min;
            this.max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

        //first soultion

        //public dynamic Length()
        //{
        //    dynamic min = this.min;
        //    dynamic max = this.max;
        //    return max - min;
        //}


        //second solution
        public T Length()
        {
            return max - min;
        }



    }
}
