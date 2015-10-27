using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Models
{
    public class NormalNumericSequenceCalculator : INumericCalculator
    {
        /// <summary>
        /// This method will return every number from 0 to the number given
        /// as parameter.
        /// </summary>
        /// <param name="number">The maximum number which can be returned</param>
        /// <returns>A collection of numbers as string collection containing all
        /// numbers between 0 and the parameter.</returns>
        public ICollection<string> ComputeSequenceWithNumber(int number)
        {
            ICollection<string> result = new List<string>();
            int i;
            for (i = 0; i <= number;i++)
            {
                result.Add(i.ToString());
            }
            return result;
        }
    }
}