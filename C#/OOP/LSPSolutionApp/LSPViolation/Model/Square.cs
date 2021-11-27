﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolation.Model
{
    class Square : Rectangle
    {
        public Square(int side) : base(side, side)
        {

        }

        public override int Height
        {
            set
            {
                _height = value;
                _width = value;
            }
        }
        public override int Width
        {
            set
            {
                _width = value;
                _height = value;
            }
        }
    }
}
