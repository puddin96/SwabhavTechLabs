using System;
using PlayerApp;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Sachin = new Player("sachin", 45, GenderType.Male);
            PrintDetails(Sachin);
            Player Virat = new Player("virat", 35, GenderType.Male);
            PrintDetails(Virat);
            Player elder = Sachin.WhoIsElder(Virat);
            PrintDetails(elder);
        }

        public static void PrintDetails(Player p)
        {
            Console.WriteLine("Player name {0}", p.Name);
            Console.WriteLine("PLayer age {0}", p.Age);
            Console.WriteLine("Player Gender {0}", p.Gender);
            Console.WriteLine(" ");

        }
    }
}
