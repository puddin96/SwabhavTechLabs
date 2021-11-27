using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryGuitarApp.Enums;

namespace InventoryGuitarApp.Model
{
    class Guitar
    {
        private string _SerialNumber;
        private double _Price;
        private Builder _Builder;
        private string _Model;
        private GTypes _gTypes;
        public Wood _BackWood;
        public Wood _TopWood;
        

        public Guitar(string SerialNumber, double Price, Builder builder, String Model, GTypes gTypes, Wood BackWood, Wood TopWood)
        {
            _SerialNumber = SerialNumber;
            _Price = Price;
            _Builder = builder;
            _Model = Model;
            _gTypes = gTypes;
            _BackWood = BackWood;
            _TopWood = TopWood;
        }

        public string SerialNumber
        {
            get
            {
                return _SerialNumber;
            }
        }

        public double Price
        {
            get
            {
                return _Price;
            }
        }

        public Builder Builder
        {
            get
            {
                return _Builder;
            }
        }

        public string Model
        {
            get
            {
                return _Model;
            }
        }

        public GTypes gTypes
        {
            get
            {
                return _gTypes;
            }
        }

        public Wood BackWood
        {
            get
            {
                return _BackWood;
            }
        }

        public Wood TopWood
        {
            get
            {
                return _TopWood;
            }
        }
    }
}
