using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Man : IManner
    {
        public void Depart()
        {
            Console.WriteLine("Man is Departing! Good Bye");
        }

        public void Wish()
        {
            Console.WriteLine("Man is Wishing");
        }
    }
}
