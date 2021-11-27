using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Polymorphism
    {
        public void print(int value)
        {
            Console.WriteLine("int value is : {0}", value);
        }

        public void print(float value)
        {
            Console.WriteLine("Float value is : {0}", value);
        }

        public void print(double value)
        {
            Console.WriteLine("Double value is : {0}", value);
        }

        public void print(bool value)
        {
            Console.WriteLine("bool value is : {0}", value);
        }

        public void print(char value)
        {
            Console.WriteLine("Char value is : {0}", value);
        }

        public void print(string str)
        {
            Console.WriteLine("String value is : {0}", str);
        }
    }
}
