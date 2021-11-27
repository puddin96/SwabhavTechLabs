using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngineeringApp.Model
{
    abstract class Person
    {
        private int _id;
        private string _address;
        private string _DateOfBirth;

        public Person(int id, string address, string dateofbirth)
        {
            this._id = id;
            this._address = address;
            this._DateOfBirth = dateofbirth;
        }

        public Person(int id, string address, string dateofbirth, double basicsalary1) : this(id, address, dateofbirth)
        {
            Basicsalary = basicsalary1;
        }
        public int id
        {
            get
            {
                return _id;
            }
        }
        public string address
        {
            get
            {
                return _address;
            }
        }
        public string dateofbirth
        {
            get
            {
                return _DateOfBirth;
            }
        }

        public double Basicsalary { get; }
        public abstract string ExtraThings();
    }
}
