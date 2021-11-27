using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSecurityApp.Model
{
    class User
    {
        private string _id;
        private string _firstName, _lastName, _email;
        protected string _password;

        public User(string id, string firstName, string lastName, string email, string password)
        {
            this._id = id;
            this._firstName = firstName;
            this._lastName = lastName;
            this._email = email;
            this._password = password;
        }

        public string GetId
        {
            get { return _id; }
        }
        public string GetFirstName
        {
            get { return _firstName; }
        }
        public string GetLastName
        {
            get { return _lastName; }
        }
        public string GetEmail
        {
            get { return _email; }
        }

        public string GetPassword
        {
            get { return _password; }
        }
    }
}
