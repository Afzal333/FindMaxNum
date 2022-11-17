using FindMaxNumber;
using NUnit.Framework;

namespace FindMaxNumTest
{
    public class Tests
    {
        FindMaxNum maxNum = new FindMaxNum();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = maxNum.FindMaxInteger(15, 5, 10);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = maxNum.FindMaxInteger(5, 15, 10);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = maxNum.FindMaxInteger(5, 10, 15);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = maxNum.FindMaxFloat(5.7F, 5.5F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }

        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
        {

            float result = maxNum.FindMaxFloat(5.5F, 5.7F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }

        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {

            float result = maxNum.FindMaxFloat(5.5F, 5.4F, 5.7F);
            Assert.AreEqual(5.7F, result);
        }

    }
}