using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    public class BMW : IAuto
    {
        public void Start()
        {
            Console.WriteLine("BMW is Starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW is Stoping");
        }
    }
}
