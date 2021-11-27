using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictApp.Model
{
    class Student
    {
        private int _RollNo;
        private int _Standard;
        private string _Name;
        private string _Location;

        public int RollNo { get; private set; }

        public Student(int RollNo, int Standard, string Name, string Location)
        {
            _RollNo = RollNo;
            _Standard = Standard;
            _Name = Name;
            _Location = Location;
        }

        public override int GetHashCode()
        {
            string hashCode = Convert.ToString(_RollNo) + Convert.ToString(_Standard);
            return int.Parse(hashCode);
        }

        public override bool Equals(object obj)
        {
            Student studentObj = (Student)obj;
            if (this._RollNo == studentObj._RollNo && this._Standard == studentObj._Standard) return true;
            return false;
        }
    }
}
