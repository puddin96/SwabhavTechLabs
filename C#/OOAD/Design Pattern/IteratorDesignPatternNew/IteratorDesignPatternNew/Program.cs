using IteratorDesignPatternNew.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternNew
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Employee("Shivam", 100));
            collection.AddEmployee(new Employee("Ben", 101));
            collection.AddEmployee(new Employee("Golu", 102));
            collection.AddEmployee(new Employee("Sagar", 103));
            collection.AddEmployee(new Employee("Yogesh", 104));
            collection.AddEmployee(new Employee("Kim", 105));


            Iterator iterator = collection.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID}");
                Console.WriteLine($"Name : {emp.Name}");
            }
            Console.Read();
        }
    }
}
