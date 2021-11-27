using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAbstractionApp.Model
{
    class Rectangle
    {
        public int height;
        public int width;

        public int Area()
        {
            int area = height * width;
            return area;
        }
        public void SetHeight(int pheight)
        {
            height = pheight;
        }
        public void SetWidth(int pwidth)
        {
            width = pwidth;
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetWidth()
        {
            return width;
        }
    }
}
