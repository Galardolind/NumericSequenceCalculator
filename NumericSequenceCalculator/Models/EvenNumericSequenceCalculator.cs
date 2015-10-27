using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Models
{
    public class EvenNumericSequenceCalculator : INumericCalculator
    {
        /// <summary>
        /// This method will return every even number from 0 to the number given
        /// as parameter.
        /// </summary>
        /// <param name="number">The maximum number which can be returned</param>
        /// <returns>A collection of numbers as string collection containing all
        /// even numbers between 0 and the parameter.</returns>
        public ICollection<string> ComputeSequenceWithNumber(int number)
        {
            ICollection<string> result = new List<string>();
            int i;
            for(i = 0; i <= number;i++)
            {
                if (IsEven(i))
                    result.Add(i.ToString());
            }
            return result;
        }

        /// <summary>
        /// This method is used to know if a number is even or not.
        /// </summary>
        /// <param name="number">The number which may be even</param>
        /// <returns>true if the number is even, false otherwise.</returns>
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}