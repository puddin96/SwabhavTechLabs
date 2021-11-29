using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegateApp
{
    delegate void MathDelegateApp(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            MathDelegateApp M1;
            M1 = Add;
            M1 += Subtract;
            M1 += Division;
            M1 += Modulus;
            M1(50, 100);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine("Addition value: " + (a+b));
            
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine("subtraction value: " + (a - b));
        }
        static void Division(int a, int b)
        {
            Console.WriteLine("Division value: " + (a / b));
        }

        static void Modulus(int a, int b)
        {
            Console.WriteLine("Modulus value: " + (a % b));
        }
    }
}
