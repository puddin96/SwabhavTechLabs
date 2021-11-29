using AccountEventLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Shivam", 5000);
            acc1.onBalanceChanged += PrintDetails;
            acc1.onBalanceChanged += UpdateDataBase;
            acc1.onBalanceChanged += SendEmailNotification;
            //   acc1.onBalanceChanged(new Account(100, "pqr", 2000));
            acc1.Deposit(1000);
            Console.ReadKey();
        }

        public static void PrintDetails(Account a)
        {
            Console.WriteLine("Accno:{0},Name:{1},Balance:{2}", a.AccNo, a.Name, a.Balance);
        }
        public static void UpdateDataBase(Account account)
        {
            Console.WriteLine("DataBase updated....");
            Console.WriteLine("Accno:{0},Name:{1},Balance:{2}", account.AccNo, account.Name, account.Balance);
        }
        public static void SendEmailNotification(Account account)
        {
            Console.WriteLine("Sending Email Notification.....");
            Console.WriteLine("Accno:{0},Name:{1},Balance:{2}", account.AccNo, account.Name, account.Balance);
        }
    }
}
