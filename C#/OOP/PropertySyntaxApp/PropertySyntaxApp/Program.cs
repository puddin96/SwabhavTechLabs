using System;
using PropertySyntaxApp;

namespace PropertySyntaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Foo();
            Console.WriteLine(f.Bar);
            f.Bar = 100;
            Console.WriteLine("Bar value {0}", f.Bar);
            Console.WriteLine("Baz value {0}", f.Baz);
            Console.WriteLine("Baz value {0}", f.Baz);
        }
    }
}
