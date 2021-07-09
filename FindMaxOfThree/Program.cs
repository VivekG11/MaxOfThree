using System;

namespace FindMaxOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Of Three........!");
            FindMaxValue maxValue = new FindMaxValue();
            double maximum = maxValue.MaxDouble(11.29f, 13.78, 29.4f);
            Console.WriteLine("Maximum Value among three is :" + maximum);
        }
    }
}
