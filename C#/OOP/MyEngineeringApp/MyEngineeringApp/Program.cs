using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEngineeringApp.Model;

namespace MyEngineeringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor(101, "Amritsar", "15/08/1980", 40000);
            Professor p2 = new Professor(102, "Mumbai", "19/09/1975", 60000);
            Student s1 = new Student(103, "Mumbai", "23/04/1996", "EXTC");
            Student s2 = new Student(104, "Delhi", "22/03/1998", "COMPS");
            PrintDetails(p1);
            PrintDetails(p2);
            PrintDetails(s1);
            PrintDetails(s2);
            Console.ReadLine();
        }
        public static void PrintDetails(SalariedEmployee p)
        {
            Console.WriteLine("=====================================================****=====================================================");
            Console.WriteLine("                                      Id                 : " + p.id);
            Console.WriteLine("                                      Address            : " + p.address);
            Console.WriteLine("                                      Date Of Birth      : " + p.dateofbirth);
            Console.WriteLine("                                      Basic Salary       : " + p.Basicsalary);
            Console.WriteLine("                                      Salary after bonus : " + p.CalcSalary());
        }
        public static void PrintDetails(Student s)
        {
            Console.WriteLine("=====================================================****=====================================================");
            Console.WriteLine("                                      Id                 : " + s.id);
            Console.WriteLine("                                      Address            : " + s.address);
            Console.WriteLine("                                      Date Of Birth      : " + s.dateofbirth);
            Console.WriteLine("                                      Branch             : " + s.Branch);
        }
       
    }
}
