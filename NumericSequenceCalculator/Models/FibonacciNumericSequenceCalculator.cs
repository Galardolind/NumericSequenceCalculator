using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Models
{
    public class FibonacciNumericSequenceCalculator : INumericCalculator
    {
        /// <summary>
        /// This method will return the fibonaci suite from 1 to the number given
        /// as parameter.
        /// </summary>
        /// <param name="number">The maximum number which can be returned</param>
        /// <returns>A collection of numbers as string collection containing the
        /// fibonacci suite numbers between 0 and the parameter</returns>
        public ICollection<string> ComputeSequenceWithNumber(int number)
        {
            ICollection<string> result = new List<string>();
            int i;
            int j;
            for (i = 0, j = 1; i <= number;)
            {
                result.Add(i.ToString());
                int tmp = i;
                i = j;
                j = tmp + j;
            }
            return result;
        }
    }
}