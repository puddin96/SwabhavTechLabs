using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product
{
    internal class BMW : IAuto
    {
        public void Start()
        {
            Console.WriteLine("BMW starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW stoping");
        }
    }
}
