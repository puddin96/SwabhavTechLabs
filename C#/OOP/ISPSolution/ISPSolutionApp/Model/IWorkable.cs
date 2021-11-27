using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    interface IWorkable
    {
        void StartWorking();

        void StopWorking();
    }
}
