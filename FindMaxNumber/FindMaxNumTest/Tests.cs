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
        FindMaxGeneric<int> maxGeneric1 = new FindMaxGeneric<int>();
        FindMaxGeneric<float> maxGeneric2 = new FindMaxGeneric<float>();
        FindMaxGeneric<string> maxGeneric3 = new FindMaxGeneric<string>();
        [Test]
        public void GivenMaxFirstNumIntegerG_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = maxGeneric1.FindMax(15, 5, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNumIntegerG_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = maxGeneric1.FindMax(5, 15, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNumIntegerG_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = maxGeneric1.FindMax(10, 5, 15);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstNumFloatG_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = maxGeneric2.FindMax(15.0F, 5F, 10F);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNumFloatG_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = maxGeneric2.FindMax(5F, 15.0F, 10F);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNumFloatG_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = maxGeneric2.FindMax(10F, 5F, 15.0F);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstNumStringG_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = maxGeneric3.FindMax("Wheat", "Rice", "Pulses");
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNumStringG_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = maxGeneric3.FindMax("Rice", "Wheat", "Pulses");
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNumStringG_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = maxGeneric3.FindMax("Rice", "Pulses", "Wheat");
            Assert.AreEqual(15, result);
        }




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
            float result = maxNumber.FindMaxFloat(15.0F, 5F, 10F);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = maxNumber.FindMaxFloat(5F, 15.0F, 10F);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = maxNumber.FindMaxFloat(10F, 5F, 15.0F);
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
