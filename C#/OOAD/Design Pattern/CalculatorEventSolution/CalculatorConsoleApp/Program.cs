using CalculatorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.OnAdditionOperationComplete += DiplayDetails;
            calc.Add(155, 50);

            calc.OnSubtractionOperationComplete += DiplayDetails;
            calc.Subtract(75, 22);
            Console.ReadKey();
        }

        public static void DiplayDetails(string type, int num1, int num2, double result)
        {
            Console.WriteLine(type);
            Console.WriteLine("First Number  : {0}", num1);
            Console.WriteLine("Second Number : {0}", num2);
            Console.WriteLine("Result        : {0}", result);

        }
    }
}
