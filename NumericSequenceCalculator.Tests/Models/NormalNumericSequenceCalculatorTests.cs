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
    public class NormalNumericSequenceCalculatorTests
    {
        [TestMethod()]
        public void ComputeSequenceWithNumber1Test()
        {
            INumericCalculator calculator = new NormalNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(9);
            List<string> expected = new List<string> { "0", "1", "2", "3", "4", "5",
                "6", "7", "8", "9" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumber2Test()
        {
            INumericCalculator calculator = new NormalNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(-1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumber3Test()
        {
            INumericCalculator calculator = new NormalNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(0);
            List<string> expected = new List<string> { "0" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}