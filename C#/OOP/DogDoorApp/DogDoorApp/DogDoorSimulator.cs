using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogDoorApp.Model;

namespace DogDoorApp
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("\nFido bark to go outside...");
            remote.PressButton();
            Console.WriteLine("\nFido has gone outside....");
            remote.PressButton();
            Console.WriteLine("\n Fido's all done...");
            remote.PressButton();
            Console.WriteLine("\n Fido back inside...");
            remote.PressButton();
            Console.ReadLine();
        }
    }
}
