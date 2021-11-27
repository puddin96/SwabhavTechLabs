using System;
using System.Configuration;
using System.IO;
using System.Text;
using TodoApp;

namespace TodoApp
{
    class TodoTest
    {
        static void Main(string[] args)
        {
            CallMe();
        }

        public static void CallMe()
        {
            Todo todo = new Todo();
            while (true)
            {
                Console.WriteLine("Enter 'y' to go inside Menu and 'n' for exiting the app:");
                int yesNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    if (yesNo == 'y')
                    {
                        Console.WriteLine("--------------------------MENU--------------------------");
                        Console.WriteLine("1 : Display");
                        Console.WriteLine("2 : Add");
                        Console.WriteLine("3 : Exit");
                        Console.WriteLine("Make a choice: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                
                                todo.Display();
                                Console.WriteLine(" ");
                                break;
                            case 2:
                                
                                Console.WriteLine("Enter the task: ");
                                string task = Convert.ToString(Console.ReadLine());
                                todo.AddInList(task);
                                break;

                            case 3:

                                todo.Exit();
                                break;
                        }
                    }
                    else if (yesNo == 'n')
                    {
                        todo.Exit();
                    }
                }

            }
        }
    }
}
