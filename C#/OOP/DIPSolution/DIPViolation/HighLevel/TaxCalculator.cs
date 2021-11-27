using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPViolation.HighLevel;
using DIPViolation.LowLevel;

namespace DIPViolation.HighLevel
{
    class TaxCalculator
    {
        private LogType _policy;
        public TaxCalculator(LogType Policy)
        {
            this._policy = Policy;

            if (_policy == LogType.DB)
            {
                Console.WriteLine(new DBLogger().WriteLine());
            }
            else
            {
                Console.WriteLine(new FileLogger().WriteLine());
            }
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
