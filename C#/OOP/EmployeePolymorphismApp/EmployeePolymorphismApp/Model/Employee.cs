using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    abstract class Employee
    {
        protected int _empNo;
        protected string _post;
        protected string _name;
        protected double _basicSalary;

        public Employee(int empno, string Post, string name, double salary)
        {
            _empNo = empno;
            _post = Post;
            _name = name;
            _basicSalary = salary;
        }

        public abstract void Calculate();

        public int Emp
        {
            get
            {
                return _empNo;
            }
        }

        public string Post
        {
            get
            {
                return _post;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Balance
        {
            get
            {
                return _basicSalary;
            }
            
        }
    }
}
