using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovableApp.Model;

namespace MovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movableArray = new IMovable[3];
            movableArray[0] = new Car();
            movableArray[1] = new Bike();
            movableArray[2] = new Truck();
            StartRace(movableArray);
            Console.ReadLine();
        }

        public static void StartRace(IMovable[] movables)
        {
            Console.WriteLine("Starting the Race");
            foreach(IMovable movable in movables)
            {
                movable.Move();
            }
        }
    }
}
