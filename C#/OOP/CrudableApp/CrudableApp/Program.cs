using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudableApp.Model;

namespace CrudableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoBoOperations(new ProductDb());
            DoBoOperations(new OrderDb());
            DoBoOperations(new PremiumCustomerDb());
            Console.ReadLine();
        }

        public static void DoBoOperations(ICrudable obj)
        {
            Console.WriteLine("Doing all db operations, please wait...");
            obj.Create();
            obj.Update();
            obj.Read();
            obj.Delete();
        }
    }
}
