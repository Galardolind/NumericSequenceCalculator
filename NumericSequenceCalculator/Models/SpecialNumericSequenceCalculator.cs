using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Models
{
    public class SpecialNumericSequenceCalculator : INumericCalculator
    {
        /// <summary>
        /// This method is used to compute a numeric sequence following this rules :
        /// - If a number is multiple of 3, replace by 'C'
        /// - If a number is multiple of 5, replace by 'E'
        /// - If a number is multiple of 3 and 5, replace by 'Z'
        /// - Otherwise add the number to the list
        /// </summary>
        /// <param name="number"></param>
        /// <returns>A collection of numbers as string collection containing the sequence</returns>
        public ICollection<string> ComputeSequenceWithNumber(int number)
        {
            ICollection<string> result = new List<string>();
            int i;
            for (i = 0; i <= number; i++)
            {
                result.Add(GetCorrespondingSuiteELement(i));
            }
            return result;
        }

        /// <summary>
        /// This method is used to replace the number by the associated letter
        /// if necessary, According to this rules :
        /// - If the number is multiple of 3, replace by 'C'
        /// - If the number is multiple of 5, replace by 'E'
        /// - If the number is multiple of 3 and 5, replace by 'Z'
        /// - Otherwise the number given as parameter
        /// </summary>
        /// <param name="number">The number which may be replaced by a char</param>
        /// <returns>The char corresponding to the rule or the number given as parameter as 
        /// string value</returns>
        public static string GetCorrespondingSuiteELement(int number)
        {
            bool isThreeMultiple = number % 3 == 0;
            bool isFiveMultiple = number % 5 == 0;

            if (isThreeMultiple && isFiveMultiple)
                return "Z";
            else if (isFiveMultiple)
                return "E";
            else if (isThreeMultiple)
                return "C";

            return number.ToString();
        }
    }
}