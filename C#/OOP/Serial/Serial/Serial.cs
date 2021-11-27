using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial
{ [Serializable]
    class Serial
    {
        double _balance;


        public Serial(double _balance)
        {
            this._balance = _balance;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine("Amount Deposited Successfully: Rs. {0}", amount);
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
