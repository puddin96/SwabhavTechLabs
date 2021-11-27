using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPViolationApp.Model;

namespace ISPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Manager();
            var r = new Robot();

            AtTheCafeteria(m);
            AtTheWorkStation(m);
            AtTheCafeteria(r);
            AtTheWorkStation(r);
            
        }

        public static void AtTheCafeteria(IWorker worker)
        {
            Console.WriteLine("At_The_Cafe");
            worker.StartEat();
            worker.StopEat();
        }

        public static void AtTheWorkStation(IWorker worker)
        {
            Console.WriteLine("At_The_WorkStation");
            worker.StartWork();
            worker.StopWork();
        }

    }
}
