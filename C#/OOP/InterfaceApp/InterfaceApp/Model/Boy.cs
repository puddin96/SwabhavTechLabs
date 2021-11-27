using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Boy : IManner, IEmotion
    {
        public void Cry()
        {
            Console.WriteLine("Boy is crying");
        }

        public void Depart()
        {
            Console.WriteLine("Boy is Deprating! Good Bye");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy is Laughing");
        }

        public void Wish()
        {
            Console.WriteLine("Boy is Wishing");
        }
    }
}
