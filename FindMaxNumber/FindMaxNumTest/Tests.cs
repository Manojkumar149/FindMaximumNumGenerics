using FindMaxNumber;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindMaxNumTest
{
    public class Tests
    {
        FindMaxNum maxNumber = new FindMaxNum();
        [Test]
        public void GivenMaxFirstNumInteger_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = maxNumber.FindMaxInteger(15, 5, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNumInteger_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = maxNumber.FindMaxInteger(5, 15, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNumInteger_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = maxNumber.FindMaxInteger(10, 5, 15);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = maxNumber.FindMaxFloat(15.0F, 5, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = maxNumber.FindMaxFloat(5, 15.0F, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = maxNumber.FindMaxFloat(10, 5, 15.0F);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstNumString_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = maxNumber.FindMaxString("Wheat", "Rice", "Pulses");
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNumString_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = maxNumber.FindMaxString("Rice", "Wheat", "Pulses");
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNumString_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = maxNumber.FindMaxString("Rice", "Pulses", "Wheat");
            Assert.AreEqual(15, result);
        }
    }
}
