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

        public override string ToString()
        {
             string reString = "Child---->  Name : " + _name + " " + "Balance : " + _balance + " " + "Gender : " + _gender + " " + "Id : " + _id;
             return reString + "\n Parent---->" + base.ToString();
        }

        public override bool Equals(object obj)
        {
            if (_name == ((Account)obj).Name || _id == ((Account)obj).Id)
            {
                return true;
            }
            else
            {
                return base.Equals(obj);
            }
            
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
