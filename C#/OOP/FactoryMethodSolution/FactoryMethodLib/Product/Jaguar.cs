﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product
{
    class Jaguar : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Jaguar starting");
        }

        public void Stop()
        {
            Console.WriteLine("Jaguar stoping");
        }
    }
}
