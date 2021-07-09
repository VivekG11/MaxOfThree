using System;

namespace FindMaxOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Of Three........!");
            FindMaxValue maxValue = new FindMaxValue();
            int maximum = maxValue.MaxInt(11, 13, 29);
            Console.WriteLine("Maximum Value among three is :"+maximum);
        }
    }
}
