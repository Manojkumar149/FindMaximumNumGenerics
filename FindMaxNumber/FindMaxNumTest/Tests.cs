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
    }
}
