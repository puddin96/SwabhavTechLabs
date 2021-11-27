using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> _items = new List<LineItem>();
        private int _itemCount;
        private double _orderTotal;
        public Order(int id, DateTime date)
        {
            this._id = id;
            this._date = date;
        }
        public void AddItem(LineItem items)
        {
            _items.Add(items);
            _itemCount += 1;
        }

        public double GetOrderTotal()
        {
            foreach (var items in Items)
            {
                _orderTotal += items.Calculate();
            }
            return _orderTotal;
        }


        public int Id
        {
            get
            {
                return _id;
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }
        public List<LineItem> Items
        {
            get
            {
                return _items;
            }
        }
        public int ItemCount
        {
            get
            {
                return _itemCount;
            }
        }
    }
}
