using DIPSolution.Common;
using DIPSolution.LowLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.HighLevel
{
    class TaxCalculator
    {
        private ILogger _policy;
        public TaxCalculator(ILogger Policy)
        {
            this._policy = Policy;
            Console.WriteLine(_policy.log());
        }

        public int Calculate(int value1, int value2)
        {
            int result = 0;
            try
            {
                result = value1 / value2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
