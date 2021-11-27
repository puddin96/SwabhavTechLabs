using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemExternalLib;

namespace ShoppingCartClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new ShoppingCart();
            s1.Add(new HatToItemAdapter(new Hat("Hat", "Golden", 500)));
            PrintDetails(s1);
        }

        public static void PrintDetails(ShoppingCart s)
        {
            Console.WriteLine("Item Details");
            foreach(Item i in s.items)
            {
                Console.WriteLine("Item Name      :" + i.Name());
                Console.WriteLine("Item Price     :" + i.Price());
            }

        }
    }
}
