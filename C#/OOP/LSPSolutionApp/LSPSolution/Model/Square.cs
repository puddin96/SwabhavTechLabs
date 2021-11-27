using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Model
{
    public class Square : IPolygon
    {
        private int _side;

        public Square(int side)
        {
            this._side = side;
        }

        public int Side
        {
            get { return _side; }
            set
            {
                _side = Side;
            }
        }

        public int CalculateArea()
        {
            return _side * _side;
        }
    }
}
