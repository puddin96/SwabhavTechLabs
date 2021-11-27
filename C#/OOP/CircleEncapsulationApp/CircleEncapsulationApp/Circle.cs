using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp
{
    class Circle
    {
        private float lower_bound = 1;
        private float upper_bound = 10;
        private float _radius = 11;
        private string _borderColor = "Red";
        private string _fillColor = "Red";
        private string defaultColor = "Red";

        public float Valid(float value)
        {
            if(value < lower_bound)
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
        public float Area()
        {
            float area = 3.14f * _radius * _radius;
            return area;
        }
        public float GetRadius()
        {
            _radius = Valid(_radius);
            return _radius;
        }
        public void SetRadius(float p_radius)
        {
            _radius = p_radius;
        }
       
        public string Get_borderColor()
        {
            _borderColor = Col(_borderColor);
            return _borderColor;

        }
        public void Set_borderColor(String p_borderColor)
        {
            _borderColor = p_borderColor;
        }
        public string Get_fillColor()
        {
            _fillColor = Col(_fillColor);
            return _fillColor;
        }
        public void Set_fillColor(String p_fillColor)
        {
            _fillColor = p_fillColor;
        }



    }
}
