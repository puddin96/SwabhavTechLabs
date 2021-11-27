using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    class Product
    {
        
        private int _id;
        private string _name;
        private double _price;
        private float _discount;
        private static int _instanceCount;

        public Product(int id, string name, double price, float discount)
        {
            _id = id;
            _name = name;
            _price = price;
            _discount = discount;
            _instanceCount += 1;
        }

        static Product()
        {
            _instanceCount = 0;
            Console.WriteLine("Static Constructor");
        }
        
        public Product(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
            _instanceCount += 1;
        }

        public double Calculate()
        {
            return _price - (_price * _discount) / 100;
        }

        public static int Occurances
        {
            get
            {
                return _instanceCount;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

        }

        public string Name
        {
            get
            {
                return _name;
            }

        }

        public double Price
        {
            get
            {
                return _price;
            }

        }

        public float Discount
        {
            get
            {
                return _discount;
            }

        }

        public int InstanceCount
        {
            get
            {
                return _instanceCount;
            }

        }
        public int GetInstanceCount
        {
            get
            {
                return _instanceCount;
            }
        }
    }
}
