using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrpViolationApp.Model;

namespace SrpViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice I = new Invoice(101, "Bill for PC", 100000, 10f, 25f);
            I.Print();
            Console.ReadLine();
        }
    }
}
