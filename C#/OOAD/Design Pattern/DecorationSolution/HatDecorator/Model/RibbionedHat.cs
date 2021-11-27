using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecorator.Model
{
    class RibbionedHat : IHatDecorator
    {
        private IHat _hat;
        private double _price = 300;
        private string _name = "RibbonHat";
        private string _description = "------";

        public RibbionedHat(IHat hat)
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
