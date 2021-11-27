using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Client;
using OCPSolutionApp.Lib;

namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Shivam", 150000, 25, new DiwaliFestivalPolicy());
            Console.WriteLine("Simple Interest : " + fd1.SimpleIntest());
            Console.ReadLine();
        }
    }
}
