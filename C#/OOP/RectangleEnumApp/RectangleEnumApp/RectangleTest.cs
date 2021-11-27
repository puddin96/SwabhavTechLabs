using System;

namespace RectangleEnumApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle();
            R1.Width = 101;
            R1.Height = 65;
            R1.Area();
            R1.BorderColor = ColorType.Red;
            PrintDetails(R1);
        }
        public static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("Width = {0}", r.Width);
            Console.WriteLine("Height = {0}", r.Height);
            Console.WriteLine("Area = {0}", r.Area());
            Console.WriteLine("BorderColor = {0}", r.BorderColor);
        }
    }
}
