using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Model
{
    class Student
    {
        private int _RollNo;
        private string _Name;
        private string _Location;

        public Student(int RollNo, string Name, string Location)
        {
            _RollNo = RollNo;
            _Name = Name;
            _Location = Location;
        }

        public override int GetHashCode()
        {
            return _RollNo;
        }

        public override bool Equals(object obj)
        {
            Student studentObj = (Student)obj;
            if (this._RollNo == studentObj.RollNo) return true;
            return false;
        }

        public int RollNo
        {
            get
            {
                return _RollNo;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
        }

        public string Location
        {
            get
            {
                return _Location;
            }
        }
    }
}
