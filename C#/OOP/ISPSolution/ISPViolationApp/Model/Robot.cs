using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    class Robot : IWorker
    {
        public void StartEat()
        {
            throw new Exception("Robots cant eat");
        }

        public void StartWork()
        {
            Console.WriteLine("StartWork");
        }

        public void StopEat()
        {
            throw new Exception("Robots cant eat");
        }

        public void StopWork()
        {
            Console.WriteLine("StopWork");
        }
    }
}
