using System;
using RectangleEncapsulationApp;
using RectangleEncapsulationApp.Model;

namespace RectangleEncapsulationApp
{
    class RectangleTest
    {
        public static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small = new Rectangle();
            small.SetHeight(500);
            small.SetWidth(60);
            int Area = small.Area(small.GetHeight(), small.GetHeight());
            Console.WriteLine("small Rectangle width:{0}, height:{1}, area:{2}", small.GetHeight(), small.GetWidth(), Area);
        }
    }
}
