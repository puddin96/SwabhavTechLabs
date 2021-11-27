using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemExternalLib;

namespace ShoppingCartClientApp
{
    class HatToItemAdapter : Item
    {
        private Hat _hat;

        public HatToItemAdapter(Hat hat)
        {
            this._hat = hat;
        }

        public string Name()
        {
            return _hat.GetShortName;
        }

        public double Price()
        {
            return _hat.Price;
        }

    }
}
