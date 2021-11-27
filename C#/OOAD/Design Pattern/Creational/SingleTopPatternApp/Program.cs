﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SingleTopPatternApp;

namespace SingleTopPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part3();

            Thread t1 = new Thread(() =>
            {
                DataService.GetInstance().DoSomething();
            });
            Thread t2 = new Thread(() =>
            {
                DataService.GetInstance().DoSomething();
            });

            t1.Start();
            t2.Start();
        }

        private static void Part3()
        {
            var sv1 = DataService.GetInstance();
            var sv2 = DataService.GetInstance();

            /*var sv1 = new DataService();
            var sv2 = new DataService();*/
            Console.WriteLine(sv1.GetHashCode());
            Console.WriteLine(sv2.GetHashCode());

            sv1.DoSomething();
            sv2.DoSomething();
        }
    }
}
