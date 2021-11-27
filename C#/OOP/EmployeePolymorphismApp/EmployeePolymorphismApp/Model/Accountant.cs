using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Accountant : Employee
    {
        private double _Perks;
        public Accountant(int empno, string post, string name, double salary) : base (empno, post, name, salary)
        {

        }
        public override void Calculate()
        {
            _Perks = (double)30 / 100 * Balance;
            Console.WriteLine("Perks   : {0}", _Perks);

        }
    }
}
