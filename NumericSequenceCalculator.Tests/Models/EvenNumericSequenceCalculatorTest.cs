using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator.Models;
using System.Collections.Generic;

namespace NumericSequenceCalculator.Models.Tests
{
    [TestClass()]
    public class EvenNumericSequenceCalculatorTest
    {

        [TestMethod]
        public void ComputeSequenceWithNumber1Test()
        {
            INumericCalculator calculator = new EvenNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(15);
            List<string> expected = new List<string> { "0", "2", "4", "6", "8", "10",
                "12", "14"};
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumber2Test()
        {
            INumericCalculator calculator = new EvenNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(-1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumber3Test()
        {
            INumericCalculator calculator = new EvenNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(0);
            List<string> expected = new List<string> { "0" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsEvenTest()
        {
            Assert.IsTrue(EvenNumericSequenceCalculator.IsEven(0));
            Assert.IsTrue(EvenNumericSequenceCalculator.IsEven(2));
            Assert.IsTrue(EvenNumericSequenceCalculator.IsEven(1898));

            Assert.IsFalse(EvenNumericSequenceCalculator.IsEven(1));
            Assert.IsFalse(EvenNumericSequenceCalculator.IsEven(3));
            Assert.IsFalse(EvenNumericSequenceCalculator.IsEven(1897));
        }
        
    }
}
