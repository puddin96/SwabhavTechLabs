using System;
using System.Linq;
using System.Reflection;
using MyUnitTestApp.Model;

namespace MyUnitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase1();

        }

        private static void TestCase1()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyUnitTestClass>().Count() > 0);
            foreach (var T in types)
            {
                NewMethod1(T);
            }


            Console.ReadLine();
        }

        private static void NewMethod1(Type T)
        {
            Console.WriteLine(T.Name + " " + "");
            var methods = T.GetMethods().Where(m => m.GetCustomAttributes<MyUnitTestMethod>().Count() > 0);
            object Cry = Activator.CreateInstance(T);
            Console.WriteLine("Number of Methods annoted: {0}", methods.Count());

            foreach (var m in methods)
            {
                var v = m.Invoke(Cry, null);
                if (v.Equals(true))
                {
                    Console.WriteLine(m.Name + " " + "-------------------->Passed");
                }
                else
                {
                    Console.WriteLine(m.Name + " " + "-------------------->Failed");
                }

            }
        }
    }
}
