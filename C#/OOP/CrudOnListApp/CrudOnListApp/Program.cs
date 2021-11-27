using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudOnListApp.Model;

namespace CrudOnListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallMe();
            //CallMe1();
            CallMe2();
            Console.ReadLine();
        }

        /*public static void CallMe()
        {
            ArrayList1 A = new ArrayList1();
            while (true)
            {
                Console.WriteLine("Enter 'y' to go inside Menu and 'n' for exiting the app:");
                int yesNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                        Console.WriteLine("--------------------------MENU--------------------------");
                        Console.WriteLine("1 : Display");
                        Console.WriteLine("2 : Add");
                        Console.WriteLine("3 : Delete");
                        Console.WriteLine("4 : Update");
                        Console.WriteLine("Make a choice: ");
                        
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");
                    switch (input)
                        {
                            case 1:

                                A.Display();
                                Console.WriteLine(" ");
                                break;
                            case 2:

                                Console.WriteLine("Enter the task: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                A.Create(num);
                                break;

                            case 3:
                                int index = Convert.ToInt32(Console.ReadLine());
                                A.Delete(index);
                                break;

                            case 4:
                                int i = Convert.ToInt32(Console.ReadLine());
                                int n = Convert.ToInt32(Console.ReadLine());
                                A.Update(i, n);
                                break;
                        }
                }

            }
        }*/


        /*public static void CallMe1()
        {
            Dictionary1 A = new Dictionary1();
            while (true)
            {
                Console.WriteLine("Enter 'y' to go inside Menu and 'n' for exiting the app:");
                int yesNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("--------------------------MENU--------------------------");
                    Console.WriteLine("1 : Display");
                    Console.WriteLine("2 : Add");
                    Console.WriteLine("3 : Delete");
                    Console.WriteLine("4 : Update");
                    Console.WriteLine("Make a choice: ");

                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    switch (input)
                    {
                        case 1:

                            A.Display();
                            Console.WriteLine(" ");
                            break;
                        case 2:

                            Console.WriteLine("Enter the task: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            string S1 = Console.ReadLine();
                            A.Create(num, S1);
                            break;

                        case 3:
                            int index = Convert.ToInt32(Console.ReadLine());
                            A.Delete(index);
                            break;

                        case 4:
                            int i = Convert.ToInt32(Console.ReadLine());
                            string n = Console.ReadLine();
                            A.Update(i, n);
                            break;
                    }
                }

            }
        }*/

        public static void CallMe2()
        {
            HashSet1 H = new HashSet1();
            while (true)
            {
                Console.WriteLine("Enter 'y' to go inside Menu and 'n' for exiting the app:");
                int yesNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("--------------------------MENU--------------------------");
                    Console.WriteLine("1 : Display");
                    Console.WriteLine("2 : Add");
                    Console.WriteLine("3 : Delete");
                    Console.WriteLine("4 : Update");
                    Console.WriteLine("Make a choice: ");

                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    switch (input)
                    {
                        case 1:
                            H.Display();
                            break;
                        case 2:
                            Console.WriteLine("Enter the task: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            string S1 = Console.ReadLine();
                            H.Create(num);
                            break;

                        case 3:
                            int index = Convert.ToInt32(Console.ReadLine());
                            H.Delete(index);
                            break;

                        case 4:
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            string n = Console.ReadLine();
                            H.Update(num1, num2);
                            break;
                    }
                }

            }
        }
    }
}
