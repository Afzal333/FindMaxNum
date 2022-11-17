using FindMaximumNumber;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIndMaxNumTest
{
    public class FindMaxGenericTest
    {
        FindMaxGeneric generic = new FindMaxGeneric();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = generic.FindMax(15, 5, 10);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = generic.FindMax(5, 15, 10);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = generic.FindMax(5, 10, 15);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = generic.FindMax(5.7F, 5.5F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }

        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
        {

            float result = generic.FindMax(5.5F, 5.7F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }

        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {

            float result = generic.FindMax(5.5F, 5.4F, 5.7F);
            Assert.AreEqual(5.7F, result);
        }
        [Test]
        public void GivenMaxFirstNumSring_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = generic.FindMax("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }

        [Test]
        public void GivenMaxSecondNumString_WhenAnalysed_ShouldReturnSecondMax()
        {

            string result = generic.FindMax("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }

        [Test]
        public void GivenMaxThirdNumString_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = generic.FindMax("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);
        }
    }
}
