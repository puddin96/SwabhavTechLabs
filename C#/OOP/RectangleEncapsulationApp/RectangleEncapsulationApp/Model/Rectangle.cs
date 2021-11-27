using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int height = 1;
        private int width = 5;
        private int lower_bound = 1;
        private int upper_bound = 100;

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

        public int Area(int pheight, int pwidth)
        {
            int area = height * width;
            return area;
        }
        public int GetHeight()
        {
            height = Valid(height);
            return height;
        }
        public int GetWidth()
        {
            width = Valid(width);
            return width;
        }
        public void SetHeight(int pheight)
        {
            height = pheight;
        }
        public void SetWidth(int pwidth)
        {
            width = pwidth;
        }
       
            
    }
}
