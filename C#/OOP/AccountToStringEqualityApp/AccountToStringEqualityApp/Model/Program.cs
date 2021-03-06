using System;
using AccountReflectorApp;

namespace AccountReflectorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            Account account1 = new ("Shivam", 50000);
            Account account2 = new ("Akshay", 40000);
            Account account3 = new ("Siddhesh", 30000);
            Account account4 = new ("Yogeshwar", 20000);
            Console.WriteLine(account1.ToString());
            Console.WriteLine(account2.Name);
            Console.WriteLine(account3.Id);
            Console.WriteLine(account4.Id);
            Console.WriteLine(" ");

            PrintDetails(account1);
            PrintDetails(account2);
            PrintDetails(account3);
            PrintDetails(account4);
        }

        private static void CaseStudy2()
        {
            Account account1 = new Account("Shivam", 500000, GenderType.Male, "C1001");
            Account account2 = new Account("Akshay", 500000, GenderType.Male, "C1002");
            Console.WriteLine(account1.GetHashCode());
            Console.WriteLine(account2.GetHashCode());
            Console.WriteLine("Refferencial activity: {0}", account1 == account2);
            Console.WriteLine("Value based equality: {0}", account1.Equals(account2));
        }

        private static void PrintDetails(Account ac)
        {
            Console.WriteLine("Name    : {0}", ac.Name);
            Console.WriteLine("Balance : {0}", ac.Balance);
            Console.WriteLine("Gender  : {0}", ac.Gender);
            Console.WriteLine("ID      : {0}", ac.Id);
            Console.WriteLine(" ");
        }
    }
}
