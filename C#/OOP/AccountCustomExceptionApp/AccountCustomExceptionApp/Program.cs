using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountCustomExceptionApp;

namespace AccountCustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("shivam", 101, 10000);
            try
            {
                
                acc1.Withdraw(9600);
            }
            
            catch (InsufficientFundsException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            finally
            {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Executes not matter exception or not");
                    PrintDetails(acc1);
            }
            
            Console.WriteLine("End of Main");
            Console.ReadLine();
        }

        public static void PrintDetails(Account A)
        {
            Console.WriteLine("a/c Number           :      {0}", A.GetAccountNumber());
            Console.WriteLine("a/c Holder name      :      {0}", A.GetName());
            Console.WriteLine("a/c Balance          :   Rs {0}", A.GetBalance());
            Console.WriteLine(" ");
        }
    }
}
