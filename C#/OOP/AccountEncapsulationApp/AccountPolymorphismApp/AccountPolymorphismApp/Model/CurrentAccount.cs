using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class CurrentAccount : Account
    {

        public CurrentAccount(int accno, string name, double balance ) : base(accno, name, balance)
        {
            
        }

        public override void Withdraw(double amount)
        {
            if(DoOverDraftCheck())
            {
                Console.WriteLine("Amount Withdrawn" + " " + amount);
                _balance = Balance - amount;
            }
        }

        private bool DoOverDraftCheck()
        {
            return true;
        }
    }
}
