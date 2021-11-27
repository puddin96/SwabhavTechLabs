using System;
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphismApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee M1 = new Manager(101, "Manager", "Shivam", 25000);
            SalarySlip(M1);
            M1.Calculate();
            Employee D1 = new Developer(102, "Developer", "Sagar", 15000);
            SalarySlip(D1);
            D1.Calculate();
            Employee A1 = new Accountant(103, "Accountant", "Sam", 10000);
            SalarySlip(A1);
            A1.Calculate();
        }
        
        

        public static void SalarySlip(Employee emp)
        {
            Console.WriteLine("---------------------------------Salary Slip---------------------------------");
            Console.WriteLine(emp.GetType().Name);
            Console.WriteLine("Employee number:     {0}", emp.Emp);
            Console.WriteLine("Employee Post:       {0}", emp.Post);
            Console.WriteLine("Employee Name:       {0}", emp.Name);
            Console.WriteLine("Employee Salary:     {0}", emp.Balance);

        }
    }
}
