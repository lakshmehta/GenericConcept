using Generic_Problem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_MaxIntegerNumber_1st_Position_ShouldReturnSame()
        {
            int max = GenericClass<int>.maximum(8, 5, 6);
            Assert.AreEqual(8, max);
        }
        [TestMethod]
        public void Given_MaxIntegerNumber_2nd_Position_ShouldReturnSame()
        {
            int max = GenericClass<int>.maximum(5, 8, 6);
            Assert.AreEqual(8, max);
        }

        [TestMethod]
        public void Given_MaxIntegerNumber_3rd_Position_ShouldReturnSame()
        {
            int max = GenericClass<int>.maximum(5, 6, 8);
            Assert.AreEqual(8, max);
        }
        [TestMethod]
        public void Given_MaxFloatNumber_1st_Position_ShouldReturnSame()
        {
            float max = GenericClass<float>.maximum(8.5f, 5.5f, 6.5f);
            Assert.AreEqual(8.5f, max);
        }
        [TestMethod]
        public void Given_MaxFloatNumber_2nd_Position_ShouldReturnSame()
        {
            float max = GenericClass<float>.maximum(5.5f, 8.5f, 6.5f);
            Assert.AreEqual(8.5f, max);
        }

        [TestMethod]
        public void Given_MaxFloatNumber_3rd_Position_ShouldReturnSame()
        {
            float max = GenericClass<float>.maximum(5.5f, 6.5f, 8.5f);
            Assert.AreEqual(8.5f, max);
        }
        [TestMethod]
        public void Given_MaxStringNumber_1st_Position_ShouldReturnSame()
        {
            string max = GenericClass<string>.maximum("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", max);
        }
        [TestMethod]
        public void Given_MaxStringNumber_2nd_Position_ShouldReturnSame()
        {
            string max = GenericClass<string>.maximum("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", max);
        }

        [TestMethod]
        public void Given_MaxStringNumber_3rd_Position_ShouldReturnSame()
        {
            string max = GenericClass<string>.maximum("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", max);
        }

    }
}
