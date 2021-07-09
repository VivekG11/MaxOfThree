using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FindMaxOfThree;
namespace TestMax
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {

            int[] intArray = { 34, 26, 29 };
            int expected = 34;
            Maximum<int> find = new Maximum<int>(intArray);

            int actual = find.MaxMethod();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod2()
        {

            float[] floatArray = { 29.3f, 17.8f, 8.9f, 28.9f };
            float expected = 29.3f;
            Maximum<float> find = new Maximum<float>(floatArray);

            float actual = find.MaxMethod();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string[] stringArray = { "Vivek", "Tvs", "Zoho" };
            string expected = "Zoho";
            Maximum<string> find = new Maximum<string>(stringArray);

            string actual = find.MaxMethod();

            Assert.AreEqual(expected, actual);
        }
    }
}
