﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    class Audi : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Audi is Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi is Stoping");
        }
    }
}
