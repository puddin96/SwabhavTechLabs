using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Manager : Employee
    {
        private double _HRA;
        private double _TA;
        private double _DA;

        

        public Manager(int empno, string post, string name, double salary) : base(empno, post, name, salary)
        {

        }

        public override void Calculate()
        {
            _HRA = (double) 50 / 100 * Balance;
            _TA = (double) 40 / 100 * Balance;
            _DA = (double) 30 / 100 * Balance;
            Console.WriteLine("HRA     : {0}", _HRA);
            Console.WriteLine("TA      : {0}", _TA);
            Console.WriteLine("DA      : {0}", _DA);
        }
        
    }
}
