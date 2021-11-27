using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    public class Tesla : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Tesla is Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla is Stoping");
        }
    }
}
