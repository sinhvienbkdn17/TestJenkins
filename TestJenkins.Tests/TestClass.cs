using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJenkins.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _cal;

        [SetUp]
        public void Setup()
        {
            _cal = new Calculator();
        }

        [Test]
        public void OnePlusOneEqualTwo()
        {
            Assert.AreEqual(2, _cal.Add(1, 1));
        }

        [Test]
        public void TwoPlusTwoEqualFour()
        {
            Assert.AreEqual(4, _cal.Add(2, 2));
        }

        [Test]
        public void FourPlusOneEqualFive()
        {
            Assert.AreEqual(7, _cal.Add(4, 1));
        }
    }
}
