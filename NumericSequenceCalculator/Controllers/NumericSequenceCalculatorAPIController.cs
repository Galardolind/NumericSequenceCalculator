using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using NumericSequenceCalculator.Models;

namespace NumericSequenceCalculator.Controllers
{

    public class NumericSequenceCalculatorAPIController : ApiController
    {

        public ICollection<string> ComputeSequence(NumericCalculatorType calculatorType, int number)
        {
            return NumericSequenceCalculatorFactory.ComputeSequenceWithNumber(calculatorType, number);
        }

        public async Task<IHttpActionResult> SecurityVerification(ICollection<string> sequence)
        {
            if (sequence == null)
            {
                return this.NotFound();
            }
            return this.Ok(sequence);
        }
        
        [Route("api/nsc/normal/{number:int:min(0)}")]
        [ResponseType(typeof(ICollection<string>))]
        public async Task<IHttpActionResult> GetNormal(int number)
        {
            return await SecurityVerification(ComputeSequence(NumericCalculatorType.Normal, number));
        }

        [Route("api/nsc/fibonacci/{number:int:min(0)}")]
        [ResponseType(typeof(ICollection<string>))]
        public async Task<IHttpActionResult> GetFibonacci(int number)
        {
            return await SecurityVerification(ComputeSequence(NumericCalculatorType.Fibonacci, number));
        }

        [Route("api/nsc/odd/{number:int:min(0)}")]
        [ResponseType(typeof(ICollection<string>))]
        public async Task<IHttpActionResult> GetOdd(int number)
        {
            return await SecurityVerification(ComputeSequence(NumericCalculatorType.Odd, number));
        }

        [Route("api/nsc/even/{number:int:min(0)}")]
        [ResponseType(typeof(ICollection<string>))]
        public async Task<IHttpActionResult> GetEven(int number)
        {
            return await SecurityVerification(ComputeSequence(NumericCalculatorType.Even, number));
        }

        [Route("api/nsc/special/{number:int:min(0)}")]
        [ResponseType(typeof(ICollection<string>))]
        public async Task<IHttpActionResult> GetSpecial(int number)
        {
            return await SecurityVerification(ComputeSequence(NumericCalculatorType.Special, number));
        }

    }
}
