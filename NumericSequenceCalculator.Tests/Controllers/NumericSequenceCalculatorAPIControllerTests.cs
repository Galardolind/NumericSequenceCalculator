using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Controllers.Tests
{
    [TestClass()]
    public class NumericSequenceCalculatorAPIControllerTests
    {

        [TestMethod()]
        public async void SecurityVerification1Test()
        {
            NumericSequenceCalculatorAPIController nscApiController = new NumericSequenceCalculatorAPIController();
            Assert.AreEqual(null, await nscApiController.SecurityVerification(null));
        }

        [TestMethod()]
        public async void SecurityVerification2Test()
        {
            NumericSequenceCalculatorAPIController nscApiController = new NumericSequenceCalculatorAPIController();
            
            var expected = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7" };
            var result = await nscApiController.SecurityVerification(expected) as ICollection<string>;
            CollectionAssert.AreEqual(expected, (List<string>)result);
        }

        [TestMethod()]
        public async void GetNormalTest()
        {
            NumericSequenceCalculatorAPIController nscApiController = new NumericSequenceCalculatorAPIController();

            var expected = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7" };
            var result = await nscApiController.GetNormal(7) as ICollection<string>;
            CollectionAssert.AreEqual(expected, (List<string>)result);
        }

        [TestMethod()]
        public async void GetFibonacciTest()
        {
            NumericSequenceCalculatorAPIController nscApiController = new NumericSequenceCalculatorAPIController();

            var expected = new List<string> { "0", "1", "1", "2", "3", "5" };
            var result = await nscApiController.GetFibonacci(7) as ICollection<string>;
            CollectionAssert.AreEqual(expected, (List<string>)result);
        }

        [TestMethod()]
        public async void GetOddTest()
        {
            NumericSequenceCalculatorAPIController nscApiController = new NumericSequenceCalculatorAPIController();

            var expected = new List<string> { "1", "3", "5", "7" };
            var result = await nscApiController.GetOdd(7) as ICollection<string>;
            CollectionAssert.AreEqual(expected, (List<string>)result);
        }

        [TestMethod()]
        public async void GetEvenTest()
        {
            NumericSequenceCalculatorAPIController nscApiController = new NumericSequenceCalculatorAPIController();

            var expected = new List<string> { "0", "2", "4", "6" };
            var result = await nscApiController.GetEven(7) as ICollection<string>;
            CollectionAssert.AreEqual(expected, (List<string>)result);
        }

        [TestMethod()]
        public async void GetSpecialTest()
        {
            NumericSequenceCalculatorAPIController nscApiController = new NumericSequenceCalculatorAPIController();

            var expected = new List<string> { "Z", "1", "2", "C", "4", "E", "C", "7" };
            var result = await nscApiController.GetSpecial(7) as ICollection<string>;
            CollectionAssert.AreEqual(expected, (List<string>)result);
        }
    }
}