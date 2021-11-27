using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryGuitarApp.Model;
using InventoryGuitarApp.Enums;

namespace InventoryGuitarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);
            //PrintGuitarDetails(inventry);

            Guitar whatErinLikes = new Guitar("", 0, Builder.Any, "model2", GTypes.Electric, Wood.Alder, Wood.Alder);

            List<Guitar> guitar = inventory.Search(whatErinLikes);

            if (guitar != null)
            {
                PrintDetails(guitar);
            }
            else
            {
                Console.WriteLine("Sorry Erin, We have nothing for you");
            }

            Console.ReadLine();
        }

        private static void PrintDetails(List<Guitar> guitarList)
        {
            Console.WriteLine("==============================Match Guitars==================================");
            Console.WriteLine("Erin, you might like this \n");
            foreach (Guitar guitar in guitarList)
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(guitar.Builder + " " + guitar.Model + " " + guitar.gTypes + " guitar :");
                Console.WriteLine(guitar.BackWood + " back and sides");
                Console.WriteLine(guitar.TopWood + " top.");
                Console.WriteLine("You can have it for only $" + guitar.Price + "! \n");
            }

        }

        private static void PrintGuitarDetails(Inventory inventory1)
        {
            Guitar guitar = inventory1.GetGuitar("S001");
            Console.WriteLine("searched element of seriel id {0}", guitar.SerialNumber);


            Console.WriteLine(guitar.SerialNumber);
            Console.WriteLine(guitar.Model);
            Console.WriteLine(guitar.gTypes);
            Console.WriteLine(guitar.TopWood);
            Console.WriteLine(guitar.BackWood);
            Console.WriteLine(guitar.Price);

        }

        private static void initializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("S001", 2500, Builder.Olson, "model1", GTypes.Acoustic, Wood.Brazilian_RoseWood, Wood.CocoBolo);
            inventory.AddGuitar("S004", 2500, Builder.Martin, "model2", GTypes.Acoustic, Wood.Brazilian_RoseWood, Wood.CocoBolo);
            inventory.AddGuitar("S002", 3000, Builder.Fender, "model2", GTypes.Electric, Wood.Mahogony, Wood.Mahogony);
            inventory.AddGuitar("S003", 2600, Builder.Fender, "model3", GTypes.Electric, Wood.Alder, Wood.Alder);
        }
    }
}
