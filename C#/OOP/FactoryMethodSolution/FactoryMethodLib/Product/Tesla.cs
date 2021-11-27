﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product
{
    internal class Tesla : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Tesla starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla stoping");
        }
    }
}
