using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class SavingsAccount : Account
    {
        public SavingsAccount(int accno, string name, double balance) : base(accno, name, balance)
        {

        }

        public override void Withdraw(double amount)
        {
            int Min_Bal = 500;
            if ((_balance - amount) > Min_Bal)
            {
                Console.WriteLine("Amount Withdrawn" + " " + amount);
                _balance -= amount; 
            }
            else
            {
                Console.WriteLine("Limit Reached");
            }
        }
    }
}
