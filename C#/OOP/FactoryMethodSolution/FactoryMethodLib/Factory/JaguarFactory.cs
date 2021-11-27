using FactoryMethodLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Factory
{
    public class JaguarFactory : IAutoFactory
    {
        private static JaguarFactory _jFactory;
        private static object locker = new object();

        public JaguarFactory()
        {
            Console.WriteLine("Jaguar Factory Created");
        }

        public IAuto Make()
        {
            return new Jaguar();
        }

        public static JaguarFactory GetInstance()
        {
            lock (locker)
            {
                if (_jFactory == null)
                {
                    _jFactory = new JaguarFactory();
                }
            }
            return _jFactory;
        }
    }
}
