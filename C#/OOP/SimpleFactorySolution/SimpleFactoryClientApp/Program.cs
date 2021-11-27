using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Factory;


namespace SimpleFactoryClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var F1 = AutomobileFactory.GetInstance();
            var auto = F1.Make(AutoType.Audi);
            auto.Start();
            auto.Stop();
            Console.WriteLine(F1.GetHashCode());


            var F2 = AutomobileFactory.GetInstance();
            var auto2 = F2.Make(AutoType.Tesla);
            auto2.Start();
            auto2.Stop();
            Console.WriteLine(F2.GetHashCode());
        }
    }
}
