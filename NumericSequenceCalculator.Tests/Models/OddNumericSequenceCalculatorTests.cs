using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Models.Tests
{
    [TestClass()]
    public class OddNumericSequenceCalculatorTests
    {
        [TestMethod]
        public void ComputeSequenceWithNumber1Test()
        {
            INumericCalculator calculator = new OddNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(15);
            List<string> expected = new List<string> { "1", "3", "5", "7", "9",
                "11", "13", "15" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumber2Test()
        {
            INumericCalculator calculator = new OddNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(-1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumber3Test()
        {
            INumericCalculator calculator = new OddNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(0);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void isOddTest()
        {
            Assert.IsTrue(OddNumericSequenceCalculator.isOdd(1));
            Assert.IsTrue(OddNumericSequenceCalculator.isOdd(3));
            Assert.IsTrue(OddNumericSequenceCalculator.isOdd(1897));

            Assert.IsFalse(OddNumericSequenceCalculator.isOdd(2));
            Assert.IsFalse(OddNumericSequenceCalculator.isOdd(4));
            Assert.IsFalse(OddNumericSequenceCalculator.isOdd(1898));
        }
    }
}