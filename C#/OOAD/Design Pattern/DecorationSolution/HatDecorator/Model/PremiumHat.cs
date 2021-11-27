using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecorator.Model
{
    class PremiumHat : IHat
    {
        private IHat _hat;
        private string _name;
        private double _price;
        private string _description;

        public PremiumHat()
        {
            _name = "Premium Hat";
            _price = 500;
            _description = ".....";
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
            return _hat.GetPrice() + _price;
        }
    }
}
