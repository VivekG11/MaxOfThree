using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FindMaxOfThree;
namespace TestMax
{
    [TestClass]
    public class UnitTest1
    {
        //AAA Methodology
        [TestMethod]
        public void TestMethod1()
        {
            //Act
            int[] intArray = { 34, 26, 29 };
            int expected = 34;//expected Value
            Maximum<int> find = new Maximum<int>(intArray);
            //Arrannge
            int actual = find.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod2()
        {
            //Act
            float[] floatArray = { 29.3f, 17.8f, 8.9f, 28.9f };
            float expected = 29.3f;//Exoected Value
            Maximum<float> find = new Maximum<float>(floatArray);
            //Arrange
            float actual = find.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Act
            string[] stringArray = { "Vivek", "Tvs", "Zoho" };
            string expected = "Zoho";//Expected Value
            Maximum<string> find = new Maximum<string>(stringArray);
            //Arrange
            string actual = find.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
