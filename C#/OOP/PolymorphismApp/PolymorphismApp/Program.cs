using System;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Polymorphism();
        }
        private static void Polymorphism()
        {
            Polymorphism poly = new Polymorphism();
            poly.print(55);
            poly.print(55.565);
            poly.print(550000);
            poly.print(true);
            poly.print("@@##$%$%");
            poly.print('H');
        }
    }
}
