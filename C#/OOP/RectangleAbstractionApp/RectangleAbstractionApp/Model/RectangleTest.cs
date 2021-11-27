using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleAbstractionApp;

namespace RectangleAbstractionApp.Model
{
    class RectangleTest
    {
        public static void Main(string[]args)
        {
            Rectangle small;
            small = new Rectangle();
            small.SetHeight(10);
            small.SetWidth(50);
            small.height = 1;
            small.width = 5;
            Rectangle big = new Rectangle();
            big.SetHeight(5);
            big.SetWidth(15);
            big.height = 100;
            big.width = 120;
            Rectangle temp = small;
            Console.WriteLine(temp.width);
            Console.WriteLine(small.width);
            temp.width = temp.width + 7;
            Console.WriteLine(temp.width);
            Console.WriteLine(small.width);
            Console.WriteLine("\nSmall Rectangle -> Width: {0} Height: {1} Area: {2}", small.width,small.height,small.Area());
            Console.WriteLine("\nBig Rectangle -> Width: {0} Height: {1} Area: {2}", big.width, big.height, big.Area());
            Console.WriteLine(small.GetHashCode());
            Console.WriteLine(big.GetHashCode());
            Console.WriteLine(temp.GetHashCode());
        }
    }
}
