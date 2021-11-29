using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateAppV2
{
    delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage F1;

            F1 = (n) =>
            {
                Console.WriteLine("Inside lambda 1");
                Console.WriteLine("Howdy says " + n);
            };

            F1("Shivam");

            F1 = (n) =>
            {
                Console.WriteLine("Hey...says " + n);
            };
            F1("swabhav");
        }
    }
}
