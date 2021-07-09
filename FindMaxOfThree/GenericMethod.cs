using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxOfThree
{
    public class Maximum<T> where T:IComparable
    {
        public T[] array;

        public Maximum(T[] array)
        {
            this.array = array;
        }

        public T[] Sort(T[] array)
        {
            Array.Sort(array);
            return array;
        }

        public T MaxValue()
        {
            var maxValue = Sort(array);
            return maxValue[array.Length - 1];
        }
        public T MaxMethod()
        {
            T maximumValue = this.MaxValue();
            return maximumValue;
        }
        
    }
}
