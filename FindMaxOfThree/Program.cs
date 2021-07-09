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

            int[] intArray = { 3, 5, 7, 22, 56, 77 };
            float[] floatArray = { 12.3f, 3, 6f, 57.4f, 33.5f };
            string[] stringArray = { "Vivek", "Dell", "Tvs" };

            Maximum<int> intMax = new Maximum<int>(intArray);
            Maximum<float> floatMax = new Maximum<float>(floatArray);
            Maximum<string> stringMax = new Maximum<string>(stringArray);

            Console.WriteLine("Max Integer value among given input is :"+intMax.MaxValue());
        }
    }
}
