using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartLib.Model;

namespace ConsoleShoppingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(101, "Shivam");

            Order order1 = new Order(1001, new DateTime(2021, 02, 12));
            order1.AddItem(new LineItem(1, new Product(401, "Chocolate", 35, 50), 4));
            order1.AddItem(new LineItem(2, new Product(401, "Chocolate", 35, 50), 10));

            Order order2 = new Order(1002, new DateTime(2021, 06, 15));
            order2.AddItem(new LineItem(1, new Product(603, "One Plus", 55000, 50), 1));
            order2.AddItem(new LineItem(2, new Product(106, "Pen", 8, 50), 10));
            order2.AddItem(new LineItem(3, new Product(108, "Controller", 1600, 50), 2));


            customer.AddOrder(order1);
            customer.AddOrder(order2);


            PrintDetails(customer);
            Console.ReadLine();
        }

        public static void PrintDetails(Customer customer)
        {
            Console.WriteLine($"Customer : {customer.Name}");
            Console.WriteLine($"Number of orders : {customer.OrderCount}");

            foreach (var orderitems in customer.Order)
            {
                Console.WriteLine("------------------***---------------------");
                Console.WriteLine($"Order Number : {orderitems.Id}");
                Console.WriteLine($"Order Date : {orderitems.Date}");
                Console.WriteLine("------------------***---------------------");
                Console.WriteLine("Order Details:");
                Console.WriteLine($"Number of Lineitems  : {orderitems.ItemCount}");
                foreach (var items in orderitems.Items)
                {
                    Console.WriteLine($"\t1] LineItem id : {items.Id}");
                    Console.WriteLine($"\t2] Product id : {items.Product.Id}");
                    Console.WriteLine($"\t3] Product Name : {items.Product.Name}");
                    Console.WriteLine($"\t4] Product Price : {items.Product.Price}");
                    Console.WriteLine($"\t5] Discounted Price : {items.Product.DiscountAmount}");
                    Console.WriteLine($"\t6] Quentity : {items.Quantity}");
                    Console.WriteLine($"LineItem total price : {items.Calculate()}");
                }
                Console.WriteLine($"Order Total : {orderitems.GetOrderTotal()}");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Total of customer {customer.Name} is {customer.CustomerTotal()}");
            Console.WriteLine("---------------------------------------");
        }


    }
}
