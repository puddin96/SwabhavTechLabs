using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printHowdy = (n) => Console.WriteLine("Howdy says " + n);
            printHowdy("Shivam");

            Action<string, string> printFullName = (fn, ln) => Console.WriteLine("First name is {0} Last name is {1} ", fn, ln);
            printFullName("Shivam", "Sutar");

            Func<int, int, long> calculateRectArea = (width, height) => width * height;
            Console.WriteLine("Result of area calcuation " + calculateRectArea(50, 10));

            Predicate<string> isLongName = (name) => name.Length > 8;
            Console.WriteLine(isLongName("Shivam"));
            string userName = "Swabhav Techlabs";
            Console.WriteLine("Is {0} a long name? {1} ", userName, isLongName(userName));
        }
    }
}
