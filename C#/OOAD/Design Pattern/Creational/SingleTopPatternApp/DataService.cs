using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTopPatternApp
{
    class DataService
    {
        private static DataService _Bucket;
        private static object locker = new object();
        DataService()
        {
            Console.WriteLine("DataService Created");
        }

        public void DoSomething()
        {
            Console.WriteLine("Work done by : " + GetHashCode());
        }

        /*public static DataService GetInstance()
        {
            if (_Bucket == null)
            {
                _Bucket = new DataService();
            }
            return _Bucket;
        }*/

        public static DataService GetInstance()
        {
            lock (locker)
            {
                if (_Bucket == null)
                {
                    _Bucket = new DataService();
                }
            }
            return _Bucket;
        }
    }
}
