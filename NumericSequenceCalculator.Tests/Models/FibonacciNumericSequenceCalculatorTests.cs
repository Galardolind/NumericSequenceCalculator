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
    public class FibonacciNumericSequenceCalculatorTests
    {
        [TestMethod()]
        public void ComputeSequenceWithNumber1Test()
        {
            INumericCalculator calculator = new FibonacciNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(15);
            List<string> expected = new List<string> { "0", "1", "1", "2", "3", "5",
                "8", "13"};
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumber2Test()
        {
            INumericCalculator calculator = new FibonacciNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(-1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumber3Test()
        {
            INumericCalculator calculator = new FibonacciNumericSequenceCalculator();
            List<string> result = (List<string>)calculator.ComputeSequenceWithNumber(0);
            List<string> expected = new List<string> { "0" };
            CollectionAssert.AreEqual(expected, result);
        }
        
    }
}