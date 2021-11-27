using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomLinkedListApp
{
    class MyCustomLinkedList <T>
    {
        private Node<T> _head;

        public MyCustomLinkedList()
        {

        }
        public void Add(T item)
        {
            if (_head == null)
            {
                _head = new Node<T>();
                _head.Data = item;
                _head.Next = null;
            }
            else
            {
                Node<T> toAdd = new Node<T>();
                toAdd.Data = item;
                Node<T> current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = toAdd;
            }

        }
        public void Remove(T item)
        {

            var current = _head;
            while (current.Next != null)
            {
                if (current.Next.Data.ToString() == item.ToString())
                {
                    current.Next = current.Next.Next;
                    break;
                }
                current = current.Next;

            }
        }
        public void Display()
        {

            Node<T> current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

        }
        public int Count()
        {
            var current = _head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}
