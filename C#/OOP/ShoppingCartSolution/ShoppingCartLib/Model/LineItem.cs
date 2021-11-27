using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class LineItem
    {
        private int _quantity;
        Product _product;
        private int _id;
        private double _totalPrice;
        public LineItem(int id, Product product, int quantity)
        {
            this._id = id;
            this._quantity = quantity;
            this._product = product;

        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }
        public Product Product
        {
            get
            {
                return _product;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public double Calculate()
        {
            _totalPrice = _product.DiscountAmount * _quantity;
            return _totalPrice;
        }
    }
}
