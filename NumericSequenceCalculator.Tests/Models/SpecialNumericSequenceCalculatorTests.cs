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
    public class SpecialNumericSequenceCalculatorTests
    {

        [TestMethod]
        public void ComputeSequenceWithNumber1Test()
        {
            INumericCalculator calculator = new SpecialNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(15);
            List<string> expected = new List<string> { "Z", "1", "2", "C", "4", "E", "C",
                "7", "8", "C", "E", "11", "C", "13", "14", "Z" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumber2Test()
        {
            INumericCalculator calculator = new SpecialNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(-1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumber3Test()
        {
            INumericCalculator calculator = new SpecialNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(0);
            List<string> expected = new List<string> { "Z" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetCorrespondingSuiteELementTest()
        {
            Assert.AreEqual("Z", SpecialNumericSequenceCalculator.GetCorrespondingSuiteELement(0));
            Assert.AreEqual("1", SpecialNumericSequenceCalculator.GetCorrespondingSuiteELement(1));
            Assert.AreEqual("C", SpecialNumericSequenceCalculator.GetCorrespondingSuiteELement(3));
            Assert.AreEqual("E", SpecialNumericSequenceCalculator.GetCorrespondingSuiteELement(5));
            Assert.AreEqual("7", SpecialNumericSequenceCalculator.GetCorrespondingSuiteELement(7));
            Assert.AreEqual("Z", SpecialNumericSequenceCalculator.GetCorrespondingSuiteELement(15));
        }
    }
}