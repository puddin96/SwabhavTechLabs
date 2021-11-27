using System;
using InheritanceConstructorApp2.Model;

namespace InheritanceConstructorApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Child C1 = new Child();
            Console.WriteLine(C1.Foo);
            Child C2 = new Child(500);
            Console.WriteLine(C2.Foo);
        }
    }
}
