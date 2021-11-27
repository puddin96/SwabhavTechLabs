using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib.Factory;
using FactoryMethodLib.Product;


namespace FactoryMethodClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1();

            Part2();

        }

        private static void Part1()
        {
            IAutoFactory factory = new BMWFactory();
            IAuto auto = factory.Make();
            auto.Start();
            auto.Stop();
        }

        private static void Part2()
        {
            var factory1 = JaguarFactory.GetInstance();
            var auto1 = factory1.Make();
            auto1.Start();
            auto1.Stop();

            var factory2 = JaguarFactory.GetInstance();
            var auto2 = factory2.Make();
            auto2.Start();
            auto2.Stop();


            Console.WriteLine(factory1.GetHashCode());
            Console.WriteLine(factory2.GetHashCode());
        }
    }
}
