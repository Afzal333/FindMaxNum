using FindMaxNumber;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxNumTest
{
    public class FindMaxGenericClass
    {
        FindMaxClassGeneric<int> generic1 = new FindMaxClassGeneric<int>();
        FindMaxClassGeneric<float> generic2 = new FindMaxClassGeneric<float>();
        FindMaxClassGeneric<string> generic3 = new FindMaxClassGeneric<string>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = generic1.FindMax(15, 5, 10);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = generic1.FindMax(5, 15, 10);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = generic1.FindMax(5, 10, 15);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = generic2.FindMax(5.7F, 5.5F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }

        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
        {

            float result = generic2.FindMax(5.5F, 5.7F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }

        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {

            float result = generic2.FindMax(5.5F, 5.4F, 5.7F);
            Assert.AreEqual(5.7F, result);
        }
        [Test]
        public void GivenMaxFirstNumSring_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = generic3.FindMax("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }

        [Test]
        public void GivenMaxSecondNumString_WhenAnalysed_ShouldReturnSecondMax()
        {

            string result = generic3.FindMax("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }

        [Test]
        public void GivenMaxThirdNumString_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = generic3.FindMax("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);
        }
    }
}
