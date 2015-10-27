using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Models
{
    public interface INumericCalculator
    {
        /// <summary>
        /// This method is used to compute numeric sequences with the number given as 
        /// parameter.
        /// </summary>
        /// <param name="number">The maximum number of the sequence computed</param>
        /// <returns>The sequence computed as string collection</returns>
        ICollection<string> ComputeSequenceWithNumber(int number);

    }
}
