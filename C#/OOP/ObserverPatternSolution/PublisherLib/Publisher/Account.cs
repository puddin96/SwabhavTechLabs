using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Publisher
{
    public class Account
    {
        private int _acNumber;
        private string _name;
        private double _balance;
        private double _mobile;
        private string _email;
        private List<INotifier> Notifier = new List<INotifier>();
        

        public Account(int accountnumber, string name, double balance)
        {
            _acNumber = accountnumber;
            _name = name;
            _balance = balance;
        }

        public Account(int accountnumber, string name, double balance, double mobile, string email)
        {
            _acNumber = accountnumber;
            _name = name;
            _balance = balance;
            _mobile = mobile;
            _email = email;
        }

        

        public void Deposit(double amt)
        {
            
            _balance += amt;
            Notify();
        }

        public void Withdraw(double amt)
        {
            _balance -= amt;
            Notify();
        }

        public void AddNotifier(INotifier notifier)
        {
            Notifier.Add(notifier);
        }

        private void Notify()
        {
            foreach (INotifier notifier in Notifier)
            {
                notifier.Notify(this);
            }
        }

        public int AcNo
        {
            get
            {
                return _acNumber;
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

        public double Mobile
        {
            get
            {
                return _mobile;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }
    }
}
