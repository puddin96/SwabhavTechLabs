using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Product;

namespace SimpleFactory.Factory
{
    public class AutomobileFactory
    {
        private static AutomobileFactory _autoFactory;
        private static object Locker = new object();

        public AutomobileFactory()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Instance Created");
        }
        public IAuto Make(AutoType auto)
        {
            
            if (auto == AutoType.Tesla)
                return new Tesla();
            else if (auto == AutoType.Audi)
                return new Audi();
            else
                return new BMW();
        }

        public static AutomobileFactory GetInstance()
        {
            lock (Locker)
            {
                if (_autoFactory == null)
                {
                    _autoFactory = new AutomobileFactory();
                }
            }
            return _autoFactory;
        }
    }
}
