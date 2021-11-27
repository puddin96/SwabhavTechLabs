using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSecurityApp.Model
{
    class SecurityService
    {
        Dictionary<string, User> userDictionary;
        User user;
        public SecurityService()
        {

            userDictionary = new Dictionary<string, User>();

        }
        public void AddUser(string id, string firstName, string lastName, string email, string password)
        {
            user = new User(id, firstName, lastName, email, password);


            userDictionary.Add(id, user);
        }

        public User Login(string id, string password)
        {

            foreach (KeyValuePair<string, User> iterateUser in userDictionary)
            {
                if (id == iterateUser.Key && password == iterateUser.Value.GetPassword)
                {
                    Console.WriteLine("login successfull");
                    return user;
                }
            }
            throw new Exception("Invalid credentials");
        }
    }
}
