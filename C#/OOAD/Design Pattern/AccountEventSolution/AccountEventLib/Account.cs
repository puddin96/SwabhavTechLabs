using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventLib
{
    public delegate void DBalanceChanged(Account account);
    public class Account
    {
        public int _accNo;
        public string _name;
        public double _balance;
        public event DBalanceChanged onBalanceChanged = null;
        public Account(int accno, string name, double balance)
        {
            this._accNo = accno;
            this._name = name;
            this._balance = balance;
        }
        public void Deposit(double amt)
        {
            _balance += amt;
            if (onBalanceChanged != null)
            {
                onBalanceChanged(this);
            }
        }
        public int AccNo
        {
            get
            {
                return _accNo;
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
