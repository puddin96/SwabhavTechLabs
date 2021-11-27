using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CrudOnListApp.Model
{
    class ArrayList1
    {

        private List<int> L = new List<int>();


        public void Create(int add)
        {
            L.Add(add);
        }

        public void Delete(int index)
        {
            for (int i = 0; i < L.Count; i++)
            {
                if (index == i)
                {
                    L.Remove(L[index - 1]); 
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < L.Count; i++)
            {
                Console.WriteLine(L[i]);
            }
        }

        public void Update(int index, int value)
        {
            for(int i = 0; i < L.Count; i++)
            {
                if (index == i)
                {
                    L[index - 1] = value;
                }
            }
        }
    }
}
