using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpSolutionApp.Model
{
    class Invoice
    {
        private int _id;
        private string _description;
        private double _amount;
        private float _tax;
        private float _discount;
        private double _Famount;

        public Invoice(int Id, string Description, double Amount, float Tax, float Discount)
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
            _Famount = (_amount - _discount) + _tax;
            return _Famount;       // 10000-2500+1000=8500 
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }

        public Double Amount
        {
            get
            {
                return _amount;
            }
        }

        public float Tax
        {
            get
            {
                return _tax;
            }
        }

        public float Discount
        {
            get
            {
                return _discount;
            }
        }
    }
}
