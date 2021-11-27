using System;

namespace AccountEncapsulationApp
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            // Part1();
            Part2();

        }

        private static void Part1()
        {
            Account a1 = new Account("Shivam Sutar", 100001, 5000);
            PrintAccountDetails(a1);
            a1.Deposite(2500);
            PrintAccountDetails(a1);

            Account a2 = new Account("Akshay Sawant", 100002, 2000);
            PrintAccountDetails(a2);
            a2.Withdraw(500);
            PrintAccountDetails(a2);

            Account a3 = new Account("Siddhesh Chikane", 100003, 3000);
            PrintAccountDetails(a3);
            a3.Deposite(500);
            PrintAccountDetails(a3);
        }
        private static void Part2()
        {
            Account[] manyAccounts = new Account[3];
            Account a1 = new Account("Shivam Sutar", 100001, 8000);
            Account a2 = new Account("Akshay Sawant", 100002, 5000);
            Account a3 = new Account("Siddhesh Chikane", 100003, 3000);
            manyAccounts[0] = a1;
            manyAccounts[1] = a2;
            manyAccounts[2] = a3;

            a1.Deposite(2000);
            a2.Withdraw(1000);
            a3.Deposite(2000);
            PrintAccountDetails(manyAccounts);

            Account wealthy = WealthyPerson(manyAccounts);
            PrintAccountDetails(wealthy);

            DistributeWealth(manyAccounts);
            PrintAccountDetails(manyAccounts);
        }

        private static void DistributeWealth(Account[] ac)
        {
            Account wealthy = WealthyPerson(ac);
            double balanceDistribute = wealthy.GetBalance() - 500;
            wealthy.Withdraw(balanceDistribute);
            for (int i = 0; i < ac.Length; i++)
            {
                if(ac[i].GetAccountNumber() != wealthy.GetAccountNumber())
                {
                    ac[i].Deposite(balanceDistribute / (ac.Length - 1));
                }
                else
                {
                    continue;
                }
            }

        }
        private static Account WealthyPerson(Account[] ac)
        {
            double wealthyAccountBalance = ac[0].GetBalance();
            Account wealthyAccount = ac[0];
            for (int i = 1; i < ac.Length; i++)
            {
                if(wealthyAccountBalance < ac[i].GetBalance())
                {
                    wealthyAccountBalance = ac[i].GetBalance();
                    wealthyAccount = ac[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Wealthiest person is: ");
            return wealthyAccount;
        }

        public static void PrintAccountDetails(Account[] ac)
        {
            for (int i = 0; i < ac.Length; i++)
            {
                Console.WriteLine("a/c Number           :      {0}", ac[i].GetAccountNumber());
                Console.WriteLine("a/c Holder name      :      {0}", ac[i].GetName());
                Console.WriteLine("a/c Balance          :   Rs {0}", ac[i].GetBalance());
                Console.WriteLine(" ");
            }
        }
        public static void PrintAccountDetails(Account ac)
        {
            Console.WriteLine("a/c Number           :      {0}", ac.GetAccountNumber());
            Console.WriteLine("a/c Holder name      :      {0}", ac.GetName());
            Console.WriteLine("a/c Balance          :   Rs {0}", ac.GetBalance());
            Console.WriteLine(" ");
        }
    }
}
