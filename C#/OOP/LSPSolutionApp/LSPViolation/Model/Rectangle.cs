using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolation.Model
{
    class Rectangle
    {
        protected int _height;
        protected int _width;

        public Rectangle (int height, int width)
        {
            _height = height;
            _width = width;
        }

        public virtual int Height
        {
            set
            {
                this._height = value;
            }
            get
            {
                return _height;
            }
        }

        public virtual int Width
        {
            set
            {
                this._width = value;
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
