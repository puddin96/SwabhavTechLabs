using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OperationsApp
{
    class Fileop
    {
        public void Write()
        {
                StreamWriter sw = new StreamWriter("C:\\Users\\Puddin\\Desktop\\1234.txt");
                sw.WriteLine("Hello World!!");
                sw.Close();
        }
        public void Read()
        {
            String line;
                StreamReader sr = new StreamReader("C:\\Users\\Puddin\\Desktop\\1234.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            
        }
        public void Edit()
        {
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader("C:\\Users\\Puddin\\Desktop\\1234.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                    Console.WriteLine("i am shivam");
                }
                reader.Close();
            }
        }
    }
}
