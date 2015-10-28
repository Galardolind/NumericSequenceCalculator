using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using NumericSequenceCalculator.Models;

namespace NumericSequenceCalculator.Tests.UITests
{
    [TestClass]
    public class UnitTest1
    {
        private const string SITE_PATH = "http://localhost/NumericSequenceCalculator/";
        FirefoxDriver ff;

        [TestCleanup]
        public void TearDown()
        {
            ff.Quit();
        }

        [TestInitialize]
        public void TearUp()
        {
            FirefoxProfile profile = new FirefoxProfile();
            profile.SetPreference("dom.forms.number", false);
            ff = new FirefoxDriver(profile);
            ff.Navigate().GoToUrl(SITE_PATH);
        }

        [TestMethod]
        public void TestMethod1()
        {
            ff.FindElement(By.Id("submit")).Click();
            Assert.IsFalse(IsElementVisible(ff.FindElement(By.Id("error-msg"))));
            Thread.Sleep(2000);
            TestContent(0);

        }

        [TestMethod]
        public void TestMethod2()
        {
            ff.FindElement(By.Id("number-input")).SendKeys("10");
            ff.FindElement(By.Id("submit")).Click();
            Assert.IsFalse(IsElementVisible(ff.FindElement(By.Id("error-msg"))));
            Thread.Sleep(2000);
            TestContent(10);
        }

        [TestMethod]
        public void TestMethod3()
        {
            ff.FindElement(By.Id("number-input")).SendKeys("aaa");
            ff.FindElement(By.Id("submit")).Click();
            Assert.IsTrue(IsElementVisible(ff.FindElement(By.Id("error-msg"))));
            Thread.Sleep(2000);
        }

        public void TestContent(int value)
        {
            Assert.AreEqual(5, ff.FindElements(By.ClassName("result-name")).Count);
            Assert.AreEqual(5, ff.FindElements(By.ClassName("result-values")).Count);
            Assert.AreEqual(5, ff.FindElements(By.ClassName("result-div")).Count);

            ICollection<string> names = new List<string> { "normal", "odd", "even", "special", "fibonacci" };

            foreach (IWebElement el in ff.FindElements(By.ClassName("result-div")))
            {
                string nameContent = el.FindElement(By.ClassName("result-name")).GetAttribute("innerHTML");
                string valuesContent = el.FindElement(By.ClassName("result-values")).GetAttribute("innerHTML");
                foreach (string name in names)
                {
                    if (nameContent.Contains(name))
                    {
                        Debug.WriteLine("remove: " + name);
                        names.Remove(name);
                        ICollection<string> expected = GetAPIResult(value, name);
                        ICollection<string> result = TransformContent(valuesContent);
                        Debug.WriteLine("values expected-size: " + expected.Count + " : " + string.Join(",", ((List<string>)expected).ToArray()));
                        Debug.WriteLine("values result-size: " + result.Count + " : " + string.Join(",", ((List<string>)result).ToArray()));
                        CollectionAssert.AreEqual(expected as List<string>, result as List<string>);
                        break;
                    }
                }
            }
            Assert.AreEqual(0, names.Count);
        }

        private ICollection<string> GetAPIResult(int value, string name)
        {
            NumericCalculatorType type = (NumericCalculatorType)Enum.Parse(typeof(NumericCalculatorType), name, true);
            return NumericSequenceCalculatorFactory.ComputeSequenceWithNumber(type, value);
        }

        private ICollection<string> TransformContent(string content)
        {
            Debug.WriteLine("values gathered : " + content);
            string reducted = content.Replace(" ", "").Replace("[", "").Replace("]", "")
                .Replace("\"", "").Replace(System.Environment.NewLine, "");
            Debug.WriteLine("values reducted : " + reducted);
            if (reducted.Length == 0)
                return new List<string>();
            return new List<string>(reducted.Split(','));
        }

        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

    }
}
