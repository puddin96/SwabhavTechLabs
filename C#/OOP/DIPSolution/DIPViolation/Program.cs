using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPViolation.HighLevel;

namespace DIPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new TaxCalculator(LogType.DB);
            Console.WriteLine(cal.Calculate(60, 12));
            Console.WriteLine(cal.Calculate(15, 0));
        }
    }
}
