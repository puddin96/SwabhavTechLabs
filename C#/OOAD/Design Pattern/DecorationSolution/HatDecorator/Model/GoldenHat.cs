using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecorator.Model
{
    class GoldenHat : IHatDecorator
    {
        private IHat _hat;
        private double _price = 500;
        private string _name = "GoldenHat";
        private string _description = "*****";

        public GoldenHat(IHat hat)
        {
            _hat = hat;
        }
        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _hat.GetPrice() + _price;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}
