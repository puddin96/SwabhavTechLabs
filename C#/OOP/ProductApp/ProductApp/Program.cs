using System;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.WriteLine("total occurences: {0}", Product.Occurances);
        }
        private static void CaseStudy1()
        {
            Product P1 = new Product(101, "apple", 500);
            Console.WriteLine(P1.InstanceCount);
            PrintDetails(P1);
            Product P2 = new Product(102, "mango", 600, 10);
            P2.Calculate();
            Console.WriteLine(P2.InstanceCount);
            PrintDetails(P2);
        }

        private static void CaseStudy2()
        {
            Product P3 = new Product(103, "app", 500, 30);
            Console.WriteLine(P3.InstanceCount);
            PrintDetails(P3);
            
            Product P4 = new Product(104, "man", 600, 10);
            Console.WriteLine(P4.InstanceCount);
            PrintDetails(P4);
            
            Product P5 = new Product(105, "grapes", 700, 20);
            Console.WriteLine(P5.InstanceCount);
            PrintDetails(P5);
            
        }

        public static void PrintDetails(Product P)
        {
            Console.WriteLine("Id: {0}", P.Id);
            Console.WriteLine("Name: {0}", P.Name);
            Console.WriteLine("Price: {0}", P.Price);
            Console.WriteLine("Discount: {0}", P.Discount);
            Console.WriteLine("Final Price: {0}", P.Calculate());
            Console.WriteLine(" ");
        }
    }
}
