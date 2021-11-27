using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    class Robot : IWorkable
    {
        public void StartWorking()
        {
            Console.WriteLine("StartWorking");
        }

        public void StopWorking()
        {
            Console.WriteLine("StopWorking");
        }
    }
}
