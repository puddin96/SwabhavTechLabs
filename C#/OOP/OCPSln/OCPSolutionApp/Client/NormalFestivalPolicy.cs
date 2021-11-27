using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Lib;

namespace OCPSolutionApp.Client
{
    class NormalFestivalPolicy : IFestivalPolicy
    {
        public double CalculateRate()
        {
            float interestRate = 7;
            return interestRate;
        }
    }
}
