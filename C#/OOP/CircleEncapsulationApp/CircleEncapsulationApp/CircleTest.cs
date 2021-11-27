using System;
using CircleEncapsulationApp;
using System.Linq;

namespace CircleEncapsulationApp
{
    class CircleTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();

            
        }

        private static void CaseStudy1()
        {
            Circle c1 = new Circle();
            c1.SetRadius(11f);
            c1.Set_borderColor("Green");
            c1.Set_fillColor("pink");
            PrintDetails(c1);
        }
        private static void CaseStudy2()
        {
            Console.WriteLine("Area of anonymous circle object is {0}", new Circle().Area());
            Console.WriteLine("Border color of anonymous circle object is {0}", new Circle().Get_borderColor());
            Console.WriteLine("Fill color of anonymous circle object is {0}", new Circle().Get_fillColor());
            PrintDetails(new Circle());
        }
        private static void CaseStudy3()
        {
            Circle c1 = new Circle();
            

            Circle[] manyCircles = new Circle[3];
            manyCircles[0] = c1;
            manyCircles[1] = new Circle();
            manyCircles[1].SetRadius(7);
            manyCircles[1].Set_borderColor("Green");
            manyCircles[1].Set_fillColor("Blue");
            manyCircles[2] = new Circle();
            manyCircles[2].SetRadius(6);
            manyCircles[2].Set_borderColor("Black");
            manyCircles[2].Set_fillColor("Red");
            PrintDetails(manyCircles[0]);
            PrintDetails(manyCircles[1]);
            PrintDetails(manyCircles[2]);

           // var list = from r in manyCircles
             //          orderby r.SetRadius
               //        select r;

        }
        private static void PrintDetails(Circle c)
        {
            float Area = c.Area();
            Console.WriteLine("radius is {0}", c.GetRadius());
            Console.WriteLine("Border color is {0}", c.Get_borderColor());
            Console.WriteLine("Fill color is {0}", c.Get_fillColor());
            Console.WriteLine("Area is {0}",Area);
        }
    }
}
