using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    abstract class Account
    {
        protected int _accno;
        protected string _name;
        protected double _balance;
        

        public Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }
       
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public abstract void Withdraw(double amount);
        
        

        public int AccNo
        {
            get
            {
                return _accno;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
