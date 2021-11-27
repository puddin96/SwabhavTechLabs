using System;
using RectangleConstructorApp;

namespace RectangleConstructorApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        
        private static void CaseStudy2()
        {
            Rectangle rect1 = new Rectangle(75, 20, "Red", "Blue");
            PrintDetails(rect1);
        }

        private static void CaseStudy1()
        {
            Rectangle r1 = new Rectangle(100, 25, "Blue");
            PrintDetails(r1);
            Rectangle r2 = new Rectangle(50, 20, "Green");
            PrintDetails(r2);
        }

        public static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("Length: {0}", r.GetLength());
            Console.WriteLine("Breadth: {0}", r.GetBreadth());
            Console.WriteLine("FillColor: {0}", r.Get_fillColor());
            Console.WriteLine("BorderColor: {0}", r.Get_borderColor());
            Console.WriteLine("Area: {0}", r.Area());
        }
    }
}
