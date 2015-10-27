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
    public class NumericSequenceCalculatorFactoryTests
    {
        [TestMethod]
        public void ComputeSequenceWithNumberEven1Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Even, 15);
            List<string> expected = new List<string> { "0", "2", "4", "6", "8", "10",
                "12", "14"};
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumberEven2Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Even, -1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumberEven3Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Even, 0);
            List<string> expected = new List<string> { "0" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ComputeSequenceWithNumberOdd1Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Odd, 15);
            List<string> expected = new List<string> { "1", "3", "5", "7", "9",
                "11", "13", "15" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumberOdd2Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Odd, -1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumberOdd3Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Odd, 0);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod]
        public void ComputeSequenceWithNumberSpecial1Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Special, 15);
            List<string> expected = new List<string> { "Z", "1", "2", "C", "4", "E", "C",
                "7", "8", "C", "E", "11", "C", "13", "14", "Z" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumberSpecial2Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Special, -1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComputeSequenceWithNumberSpecial3Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Special, 0);
            List<string> expected = new List<string> { "Z" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumberNormal1Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Normal, 9);
            List<string> expected = new List<string> { "0", "1", "2", "3", "4", "5",
                "6", "7", "8", "9" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumberNormal2Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Normal, -1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumberNormal3Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Normal, 0);
            List<string> expected = new List<string> { "0" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumberFibonacci1Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Fibonacci, 15);
            List<string> expected = new List<string> { "0", "1", "1", "2", "3", "5",
                "8", "13"};
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumberFibonacci2Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Fibonacci, -1);
            List<string> expected = new List<string> { };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ComputeSequenceWithNumberFibonacci3Test()
        {
            List<string> result = (List<string>)NumericSequenceCalculatorFactory
                .ComputeSequenceWithNumber(NumericCalculatorType.Fibonacci, 0);
            List<string> expected = new List<string> { "0" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}