using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Player
    {
        string _name;
        int _age;
        GenderType _gender;
        public Player (String _name):this(_name, 18, GenderType.Male)
        {
        }
        public Player(String _name, int _age, GenderType _gender)
        {
            this._name = _name;
            this._age = _age;
            this._gender = _gender;
        }

        public Player WhoIsElder(Player p)
        {
            if (this._age > p._age)
            {
                return this;
            }
            else
            {
                return p;
            }
        }
        

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public GenderType Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
    }
}
