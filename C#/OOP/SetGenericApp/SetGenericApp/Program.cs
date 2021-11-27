using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetGenericApp.Model;

namespace SetGenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            HashSet<int> nos = new HashSet<int>();
            nos.Add(10);
            nos.Add(200);
            nos.Add(5);
            nos.Add(5);
            nos.Add(300);
            Console.WriteLine("Total element : {0}", nos.Count());


            foreach (int item in nos)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static void CaseStudy2()
        {
            Student student1 = new Student(101, "shivam", "Mumbai");
            Student student2 = new Student(101, "shivam", "Mumbai");
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine(student2.GetHashCode());
            /*HashSet<Student> S1 = new HashSet<Student>();
            S1.Add(new Student(101, "shivam", "Mumbai"));
            S1.Add(new Student(101, "shivam", "Mumbai"));
            Console.WriteLine(S1.Count);
            foreach (Student item in S1)
            {
                Console.WriteLine(item);
            }*/
            Console.ReadLine();
        }
    }
}
