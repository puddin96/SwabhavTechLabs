using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecorator.Model
{
    class StandardHat : IHat
    {
        private string _name;
        private double _price;
        private string _description;

        public StandardHat()
        {
            this._name = "Standard Hat";
            this._description = "123456789";
            this._price = 250;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
