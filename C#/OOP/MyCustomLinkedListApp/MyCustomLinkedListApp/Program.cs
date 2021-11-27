using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomLinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomLinkedList<int> myList = new MyCustomLinkedList<int>();
            myList.Add(50);
            myList.Add(100);
            myList.Add(150);
            myList.Add(200);



            myList.Display();
            Console.WriteLine("\nTotal ELements : {0} \n", myList.Count());

            myList.Remove(200);

            myList.Display();

            Console.WriteLine("\nTotal ELements : {0} \n", myList.Count());
            myList.Count();

        }
    }
}
