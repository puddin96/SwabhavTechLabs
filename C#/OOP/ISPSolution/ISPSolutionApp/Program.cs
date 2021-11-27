using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolutionApp.Model;

namespace ISPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var robot = new Robot();
            AtTheCafeterial(manager);
            AtTheWorkStation(manager);
            //AtTheCafeterial(robot);
            AtTheWorkStation(robot);
        }

        private static void AtTheWorkStation(IWorkable worker)
        {
            worker.StartWorking();
            worker.StopWorking();
        }

        private static void AtTheCafeterial(IEatable worker)
        {
            worker.StartEating();
            worker.StopEating();
        }
    }
}
