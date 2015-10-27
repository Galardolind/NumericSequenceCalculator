using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Models
{
    /// <summary>
    /// This enum contains all type of numeric sequence calculator which can be used.
    /// </summary>
    public enum NumericCalculatorType
    {
        Normal,
        Fibonacci,
        Even,
        Odd,
        Special
    }

    public class NumericSequenceCalculatorFactory
    {

        /// <summary>
        /// This factory is made to use the NumericSequenceCalculator associated with the enum NumericCalculatorType.
        /// </summary>
        /// <param name="calculatorType">The type of calculator which will be used to compute the sequence</param>
        /// <param name="number">The maximum number of the sequence</param>
        /// <returns>A collection of numbers as string collection containing the sequence, or null
        /// if the NumericCalculatorType haven't a class associated with it.</returns>
        public static ICollection<string> ComputeSequenceWithNumber(NumericCalculatorType calculatorType,int number)
        {
            INumericCalculator calculator = null;
            switch (calculatorType)
            {
                case NumericCalculatorType.Normal:
                    calculator = new NormalNumericSequenceCalculator();
                    break;
                case NumericCalculatorType.Fibonacci:
                    calculator = new FibonacciNumericSequenceCalculator();
                    break;
                case NumericCalculatorType.Even:
                    calculator = new EvenNumericSequenceCalculator();
                    break;
                case NumericCalculatorType.Odd:
                    calculator = new OddNumericSequenceCalculator();
                    break;
                case NumericCalculatorType.Special:
                    calculator = new SpecialNumericSequenceCalculator();
                    break;
                default:
                    break;
            }
            if(calculator != null)
            {
                return calculator.ComputeSequenceWithNumber(number);
            } else
            {
                return null;
            }
        }
    }
}