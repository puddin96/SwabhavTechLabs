using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEncapsulationApp
{
    class Account
    {
        private string _name;
        private int _accountNum;
        private double _balance;

        public Account(string name, int accountNum, double balance)
        {
            _name = name;
            _accountNum = accountNum;
            _balance = balance;
        }

        public void Deposite(double amount)
        {
            _balance += amount;
            Console.WriteLine("Amount Deposited Successfully: Rs. {0} in a/c {1}", amount, _accountNum);
        }

        public void Withdraw(double amount)
        {
            int Min_Bal = 500;
            if (_balance - amount < Min_Bal)
            {
                Console.WriteLine("a/c {0} error Withdraw Transaction Cancelled : Minimum balance should be 500", _accountNum);
            }
            else
            {
                _balance -= amount;
                Console.WriteLine("Withdraw amount Rs.{0} Successful in a/c {1}", amount, _accountNum);
            }
               
        }
        public string GetName()
        {
            return _name;
        }
        public int GetAccountNumber()
        {
            return _accountNum;
        }
        public Double GetBalance()
        {
            return _balance;
        }
    }
}
