using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CrudOnListApp.Model
{
    class Dictionary1
    {
        private Dictionary<int, string> D = new Dictionary<int, string>();


        public void Create(int add, string S1)
        {
            D.Add(add, S1);
        }

        public void Delete(int index)
        {
            D.Remove(index);
        }

        public void Display()
        {
            foreach (KeyValuePair <int, string> item in D )
            {
                Console.WriteLine("key = {0}, value = {1}",item.Key, item.Value);
            }
        }

        public void Update(int index, string value)
        {
            D.Remove(index);
            D.Add(index, value);
        }
    }
}
