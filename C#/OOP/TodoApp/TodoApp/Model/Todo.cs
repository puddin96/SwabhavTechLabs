using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Todo
    {
        private readonly string filePath = "E:/SwabhavTech/C#/OOP/TodoApp/TodoApp/bin/Debug/net5.0/SavedFile.txt";
        public string[] _toDoArray = new string[10];
        public void Display()
        {
            FileStream fs = new FileStream("E:/SwabhavTech/C#/OOP/TodoApp/TodoApp/bin/Debug/net5.0/SavedFile.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            fs.Close();
            sr.Close();
        }
    

      

        public void AddInList(string abc)
        {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(abc.ToString());
                    Console.WriteLine("Task added");
                    Console.WriteLine(" ");
                    writer.Close();
                }
        }

        public void Exit()
        {
            FileStream fs1 = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            Console.WriteLine("Saving!");
            Console.WriteLine("Bye Bye");
            Environment.Exit(1);
        }

    }
}
