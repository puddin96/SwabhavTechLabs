using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    class Manager : IWorkableEatable
    {
        public void StartEating()
        {
            Console.WriteLine("StartEating");
        }

        public void StartWorking()
        {
            Console.WriteLine("StartWorking");
        }

        public void StopEating()
        {
            Console.WriteLine("StopEating");
        }

        public void StopWorking()
        {
            Console.WriteLine("StopWorking");
        }
    }
}
