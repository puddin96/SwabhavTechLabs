using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingApp
{
    class Program
    {

        public static void Main(string[] args)
        {
            PrintDetails(50);
            PrintDetails("Hello");
            PrintDetails(100.55);
            PrintDetails(10.10f);
            PrintDetails(false);
            PrintDetails('#');
         
        }
        private static void PrintDetails(int content)
        {
            Console.WriteLine("Overload #1 : integer");
            Console.WriteLine(content);
        }
        private static void PrintDetails(String content)
        {
            Console.WriteLine("Overload #2 : string");
            Console.WriteLine(content);
        }
        private static void PrintDetails(Double content)
        {
            Console.WriteLine("Overload #3 : Double");
            Console.WriteLine(content);
        }
        private static void PrintDetails(float content)
        {
            Console.WriteLine("Overload #4 : Float");
            Console.WriteLine(content);

        }
        private static void PrintDetails(Boolean content)
        {
            Console.WriteLine("Overload #5 : Boolean");
            Console.WriteLine(content);
        }
        private static void PrintDetails(Char content)
        {
            Console.WriteLine("Overload #6 : char");
            Console.WriteLine(content);
        }
    }

}
