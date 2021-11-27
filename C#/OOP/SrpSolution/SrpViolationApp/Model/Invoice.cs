using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpViolationApp.Model
{
    class Invoice
    {
        private int _id;
        private string _description;
        private double _amount;
        private float _tax;
        private float _discount;
        private double _Famount;

        public Invoice (int Id, string Description, double Amount, float Tax, float Discount)
        {
            this._id = Id;
            this._description = Description;
            this._amount = Amount;
            this._tax = Tax;
            this._discount = Discount;
        }

        public double CalculateDiscount()
        {
            _discount = (float)(_amount * _discount / 100);
            return _discount;
        }

        public double CalculateTax()
        {
            _tax = (float)(_amount * _tax / 100);
            return _tax;
        }

        public double CalculateFinalAmount()
        {              //10000 -   2500     +  1000
            _Famount =(_amount - _discount) + _tax;
            return _Famount;       // 10000-2500+1000=8500 
        }

        public void Print()
        {
            Console.WriteLine("Invoice Id: {0}", _id);
            Console.WriteLine("Invoice Description: {0}", _description);
            Console.WriteLine("Invoice Amount: {0}", _amount);
            Console.WriteLine("Invoice GST tax: {0}%", _tax);
            Console.WriteLine("Invoice Discount: {0}%", _discount);
            Console.WriteLine("Discounted amount: {0}", CalculateDiscount());
            Console.WriteLine("Tax amount: {0}", CalculateTax());
            Console.WriteLine("Final amount: {0}", CalculateFinalAmount());
        }
    }
}
