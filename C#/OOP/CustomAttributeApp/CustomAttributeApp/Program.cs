using System;
using System.Linq;
using System.Reflection;

namespace CustomAttributeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                GetAnnotation(typeof(Foo));
            }

        }
        public static void GetAnnotation(Type t)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(T => t.GetCustomAttributes<NeedToRefactor>().Count() > 0);


            var methods = t.GetMethods().Where(m => m.GetCustomAttributes<NeedToRefactor>().Count() > 0);

            Console.WriteLine("Number of Methods annoted: {0}", methods.Count());
            foreach (var m in methods)
            {
                Console.WriteLine(m.ReturnType.Name + " " + m.Name);
            }
            Console.ReadLine();
        }



    }
}
