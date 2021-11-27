using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOnListApp.Model
{
    class HashSet1
    {
        HashSet<int> H = new HashSet<int>();

        public void Create(int num)
        {
            H.Add(num);
        }

        public void Delete(int index)
        {
            H.Remove(index);
        }

        public void Display()
        {
            if (H.Count == 0)
            {
                Console.WriteLine("no values set");
            }
            else
            {
                foreach (int items in H)
                {
                    Console.WriteLine(items);
                }
            }
            
        }

        public void Update(int num1, int num2)
        {
            H.Remove(num1);
            H.Add(num2);
        }
    }
}
