using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private ColorType _borderColor;
        private int lower_bound = 1;
        private int upper_bound = 100;
       

        public int Area()
        {
            int area = _height * _width;
            return area;
        }
        public int Valid(int value)
        {
            if (value < lower_bound)
            {
                Console.WriteLine("Print value is set to 1 ", value);
                return lower_bound;
            }
            else if (value > upper_bound)
            {
                Console.WriteLine("Print value is set to 100 ", value);
                return upper_bound;
            }
            else
            {
                return value;
            }

        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                
                    _width = Valid(value);
                
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {

                _height = Valid(value);

            }
        }

        public ColorType BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
            }
        }
        

    }
}
