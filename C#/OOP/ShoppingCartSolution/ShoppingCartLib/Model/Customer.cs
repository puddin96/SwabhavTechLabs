using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _order = new List<Order>();
        private int _orderCount;
        private double _customerTotal;
        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        public void AddOrder(Order order)
        {
            _order.Add(order);
            _orderCount += 1;
        }

        public double CustomerTotal()
        {
            foreach (var items in Order)
            {
                _customerTotal += items.GetOrderTotal();
            }
            return _customerTotal;
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
        public List<Order> Order
        {
            get
            {
                return _order;
            }
        }
        public int OrderCount
        {
            get
            {
                return _orderCount;
            }
        }
    }
}
