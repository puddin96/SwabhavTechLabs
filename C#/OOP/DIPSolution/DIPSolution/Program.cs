using DIPSolution.HighLevel;
using DIPSolution.LowLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new TaxCalculator(new DBLogger());
            Console.WriteLine(cal.Calculate(10, 5));
            Console.WriteLine(cal.Calculate(100, 10));
        }
    }
}
