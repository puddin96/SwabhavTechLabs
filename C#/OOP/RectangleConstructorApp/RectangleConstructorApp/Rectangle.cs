using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    class Rectangle
    {
        private int lower_bound = 1;
        private int upper_bound = 100;
        private int _length;
        private int _breadth;
        private string _borderColor = "Red";
        private string _fillColor = "Red";
        private string defaultColor = "Red";

        public Rectangle(int length, int breadth, string color)
        {
            _length = length;
            _breadth = breadth;
            _fillColor = color;
        }
        public Rectangle(int length, int breadth, string color, string borderColor)
        {
            _length = length;
            _breadth = breadth;
            _fillColor = color;
            _borderColor = borderColor;
        }

        public int Valid(int value)
        {
            if (value < lower_bound)
            {
                Console.WriteLine("Print value set to 1 ", value);
                return lower_bound;
            }
            else if (value > upper_bound)
            {
                Console.WriteLine("Print value set to 10 ", value);
                return upper_bound;
            }
            else
            {
                return value;
            }
        }
        public string Col(String color)
        {
            if (color != "Red" && color != "Green" && color != "Blue")
            {
                return defaultColor;
            }
            else
            {
                return color;
            }
        }
        public int Area()
        {
            int area = _length * _breadth;
            return area;
        }
        public int GetLength()
        {
            _length = Valid(_length);
            return _length;
        }
        
        public int GetBreadth()
        {
            _breadth = Valid(_breadth);
            return _breadth;
        }
        
        public string Get_borderColor()
        {
            _borderColor = Col(_borderColor);
            return _borderColor;

        }
       
        public string Get_fillColor()
        {
            _fillColor = Col(_fillColor);
            return _fillColor;
        }
       
    }
    
}
