using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class LineItem
    {
        private string _ProductName;
        private double _ProductPrice;
        private int _ProductQuantity;

        public LineItem(string Pname, double Pprice, int Pquantity)
        {
            _ProductName = Pname;
            _ProductPrice = Pprice;
            _ProductQuantity = Pquantity;
        }

        public double TotalPrice()
        {
            double _TotalPrice = _ProductPrice * _ProductQuantity;
            return _TotalPrice;
        }


        public string Pname
        {
            get
            {
                return _ProductName;
            }
        }

        public double Pprice
        {
            get
            {
                return _ProductPrice;
            }
        }

        public int Pquantity
        {
            get
            {
                return _ProductQuantity;
            }
        }
        
    }
}
