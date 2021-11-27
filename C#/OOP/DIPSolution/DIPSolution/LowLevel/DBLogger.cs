using DIPSolution.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.LowLevel
{
    class DBLogger : ILogger
    {
        public string log()
        {
            return ("Logging to DB");
        }
    }
}
