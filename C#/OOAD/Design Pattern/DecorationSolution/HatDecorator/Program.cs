using HatDecorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HatDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IHat hat = new RibbionedHat(new GoldenHat(new StandardHat()));
            Console.WriteLine(hat.GetName());
            Console.WriteLine(hat.GetDescription());
            Console.WriteLine(hat.GetPrice());
        }
    }
}
