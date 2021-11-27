using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionApp.Model;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("Earphones", 150, 2));
            basket.Add(new LineItem("Toys", 500, 3));
            basket.Add("Hello World");
            foreach (LineItem item in basket)
            {
                Console.WriteLine("Name : {0}", item.Pname);
                Console.WriteLine("Price : {0}", item.Pprice);
                Console.WriteLine("Quantity : {0}", item.Pquantity);
                
                Console.WriteLine(" ");
            }
            double FinalPrice = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("Product Name : {0}, Product Price : {1}, Product Quantity : {2}", item.Pname, item.Pprice, item.Pquantity);
                Console.WriteLine("Total Price : {0}", item.TotalPrice());
                FinalPrice += item.TotalPrice();
            }
            Console.WriteLine("Final Bill : {0}", FinalPrice);
            Console.ReadLine();
        }

        private static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("Bag", 650, 2));
            basket.Add(new LineItem("Chips", 50, 3));
            foreach (LineItem item in basket)
            {
                Console.WriteLine("Name : {0}", item.Pname);
                Console.WriteLine("Price : {0}", item.Pprice);
                Console.WriteLine("Quantity : {0}", item.Pquantity);
                Console.WriteLine(" ");
            }
            double FinalPrice = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("Product Name : {0}, Product Price : {1}, Product Quantity : {2}", item.Pname, item.Pprice, item.Pquantity);
                Console.WriteLine("Total Price : {0}", item.TotalPrice());
                FinalPrice += item.TotalPrice();
            }
            Console.WriteLine("Final Bill : {0}", FinalPrice);
            Console.ReadLine();
        }

    }
}
