using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    class Manager : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Work");
        }

        public void StopEat()
        {
            Console.WriteLine("StopEat");
        }

        public void StopWork()
        {
            Console.WriteLine("StopWork");
        }
    }
}
