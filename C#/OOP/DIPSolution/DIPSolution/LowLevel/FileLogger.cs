using DIPSolution.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.LowLevel
{
    class FileLogger : ILogger
    {
        public string log()
        {
            return ("Logging to File");
        }
    }
}
