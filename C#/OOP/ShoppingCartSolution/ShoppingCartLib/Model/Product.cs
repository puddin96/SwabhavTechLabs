using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discount;
        private double _discoutAmount;
        public Product(int id, string name, double price, float discount)
        {
            this._id = id;
            this._name = name;
            this._price = price;
            this._discount = discount;
            CalculateDiscount(_price);
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
        public override int GetHashCode()
        {
            return Id;
        }
        public override bool Equals(object obj)
        {
            if (this.Id == obj.GetHashCode())
            {
                return true;
            }
            return false;
        }
        public double CalculateDiscount(double amout)
        {
            _discoutAmount = _discount / 100 * _price;
            return _discoutAmount;
        }
        public double DiscountAmount
        {
            get
            {
                return _discoutAmount;
            }
        }
    }
}
