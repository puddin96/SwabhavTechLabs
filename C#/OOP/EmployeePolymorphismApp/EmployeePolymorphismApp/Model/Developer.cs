using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Developer : Employee
    {
        private double _PA;
        private double _OT;
        public Developer(int empno,  string post, string name, double salary) : base (empno, post, name, salary)
        {
            
        }

        public override void Calculate()
        {
            _PA = (double) 40 / 100 * Balance;
            _OT = (double) 30 / 100 * Balance;
            Console.WriteLine("PA      : {0}", _PA);
            Console.WriteLine("OT      : {0}", _OT);
        }
    }
}
