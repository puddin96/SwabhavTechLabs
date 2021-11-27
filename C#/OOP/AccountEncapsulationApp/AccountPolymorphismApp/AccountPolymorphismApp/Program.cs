using System;
using AccountPolymorphismApp.Model;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount acc1 = new SavingsAccount(101, "shivam", 500000);
            PrintDetails(acc1);
            CurrentAccount acc2 = new CurrentAccount(102, "yogesh", 450000);
            PrintDetails(acc2);
            acc1.Withdraw(50000);
            PrintDetails(acc1);
            acc2.Withdraw(50000);
            PrintDetails(acc2);
        }

        private static void PrintDetails(Account acc)
        {
            Console.WriteLine("AccountNo          :{0} ", acc.AccNo);
            Console.WriteLine("AccountName        :{0} ", acc.Name);
            Console.WriteLine("Balance            :{0} ", acc.Balance);
            Console.WriteLine(" ");
        }
    }
}
