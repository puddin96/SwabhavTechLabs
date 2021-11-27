using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp
{
    class MyQueue<T> : IQueue<T>
    {
        LinkedList<T> L1 = new LinkedList<T>();

        public int Count()
        {
            return this.L1.Count();
        }

        public T DeQueue()
        {
            var FirstItem = L1.First();
            this.L1.RemoveFirst();
            return FirstItem;
        }

        public void Enque(T item)
        {
            this.L1.AddLast(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return L1.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return L1.GetEnumerator();
        }
    }
}
