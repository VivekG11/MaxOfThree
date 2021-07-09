using System;

namespace FindMaxOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Of Three........!");
            FindMaxValue maxValue = new FindMaxValue();
            string maximum = maxValue.MaxString("Tvs","Vivek","Dell");
            Console.WriteLine("Maximum Value among three is :" + maximum);
        }
    }
}
