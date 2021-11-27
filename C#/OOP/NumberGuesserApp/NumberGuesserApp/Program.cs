using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public void Game()
        {
            Random rand = new Random();
            int guess = 0;
            string welcome = "Guess a number between 1 and 100";
            int num = rand.Next(1, 100);
            Console.WriteLine(welcome);


            int i = 0;

            while (guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > num)
                    {
                        Console.WriteLine("Sorry, Too High");
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Sorry, Too Low");
                    }
                    else
                    {
                        Console.WriteLine("Congrats, it took you " + i + " tries");
                        Console.ReadLine();
                    }
                }

                catch
                {
                    Console.WriteLine("Guess must be a number");
                    i--;
                }


                i++;

            }
        }

        public static void Main(string[] args)
        {
            string retry = "yes";
            do
            {
                Program p = new Program();
                p.Game();
                Console.WriteLine("choose option 1 to continue and 2 to exit");
                int cont = Convert.ToInt32(Console.ReadLine()); ;

                switch (cont)
                {
                    case 1:
                        p.Game();
                        break;
                    case 2:
                        retry = "No";
                        break;
                    default:
                        p.Game();
                        break;


                }
            }
            while (retry != "No");

        }
    }
}