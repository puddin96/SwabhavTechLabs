using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Model
{
    public class Rectangle : IPolygon
    {
        protected int _height;
        protected int _width;

        public Rectangle(int width, int height)
        {
            this._height = height;
            this._width = width;

        }

        public int Height
        {
            set
            {
                _height = value;
            }
            get
            {
                return _height;
            }
        }

        public int Width
        {
            set
            {
                _width = value;
            }
            get
            {
                return _width;
            }
        }

        public int CalculateArea()
        {
            return _height * _width;
        }

    }
}
