using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserSecurityApp.Model;

namespace UserSecurityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SecurityService secure = new SecurityService();
            secure.AddUser("1001", "Shivam", "Sutar", "sutarshivam270@gmail.com", "123123");
            secure.AddUser("1002", "Shivam", "Sutar", "sutarshivam270@gmail.com", "4545");
            secure.Login("1002", "4545");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
