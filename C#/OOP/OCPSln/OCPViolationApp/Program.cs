using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPViolationApp.Model;

namespace OCPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit("Akshay", 150000, 5, FestivalType.Diwali);
            Console.WriteLine(fd1.SimpleInterest());
            Console.ReadLine();
        }
    }
}
