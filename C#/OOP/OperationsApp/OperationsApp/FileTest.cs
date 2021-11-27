using System;
using System.IO;

namespace OperationsApp
{
    class FileTest
    {
        static void Main(string[] args)
        {
            Fileop fw = new Fileop();
            while (true)
            {
                Console.WriteLine("1 : Write");
                Console.WriteLine("2 : Edit");
                Console.WriteLine("3 : Read");
                Console.WriteLine("Make a choice: ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        fw.Write();
                        Console.WriteLine("Write operation successfull");
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        fw.Edit();
                        Console.WriteLine("Edit operation successfull");
                        break;
                    case 3:
                        
                        fw.Read();
                        Console.WriteLine(" ");
                        break;

                }
            }
            
        }
    }
}
