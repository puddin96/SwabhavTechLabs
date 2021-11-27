using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEngineeringApp.Model;

namespace MyEngineeringApp.Model
{
    abstract class SalariedEmployee : Person
    {
        
            private double _basicSalary;

            public SalariedEmployee(int id, string address, string dateofbirth, double basicsalary) : base(id, address, dateofbirth, basicsalary)
            {

                _basicSalary = basicsalary;
            }

            public abstract double CalcSalary();


        
    }
}
