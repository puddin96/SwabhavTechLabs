using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountReflectorApp
{
    class Account
    {
        private string _name;
        private float _balance;
        private GenderType _gender;
        private string _id;
        private static int _count;


        static Account()
        {
            _count += 1001;
        }

        public Account(string name, float balance)
        {
            _name = name;
            _balance = balance;
            _id = "C" + _count;
            _count += 1;
        }

        public Account(string name, float balance, GenderType gender, string id)
        {
            _name = name;
            _balance = balance;
            _gender = gender;
            _id = id;
            _id = "C" + _count;
            _count += 1;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public float Balance
        {
            get
            {
                return _balance;
            }
        }

        public GenderType Gender
        {
            get
            {
                return _gender;
            }
        }

        public string Id
        {
            get
            {
                return _id;
            }
        }

    }
}
