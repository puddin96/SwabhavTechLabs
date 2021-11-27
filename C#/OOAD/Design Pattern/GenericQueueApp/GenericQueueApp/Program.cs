using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var I1 = new MyQueue<int>();
            I1.Enque(50);
            I1.Enque(100);
            I1.Enque(150);
            I1.Enque(200);
            I1.Enque(250);
            Part1(I1);
            Part2(I1);
        }
        public static void Part1(IQueue<int> num)
        {
            Console.WriteLine("Count : " + num.Count());
            Console.WriteLine("DeQueue : " + num.DeQueue());
            Console.WriteLine("Count after DeQueue operation : " + num.Count());
        }

        private static void Part2(IQueue<int> numbers)
        {
            iteratUsingFor(numbers);
            iterateWithoutUsingFor(numbers);
        }

        private static void iterateWithoutUsingFor(IQueue<int> numbers)
        {
            Console.WriteLine("\nIterate wihout using for loop........");
            IEnumerator<int> iterator = numbers.GetEnumerator();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }

        private static void iteratUsingFor(IQueue<int> numbers)
        {
            Console.WriteLine("\nIterate using For Loop......");
            foreach (int iterator in numbers)
            {
                Console.WriteLine(iterator);
            }
        }

    }
}
