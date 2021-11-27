using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomLinkedListApp
{
    public class Node<T>
    {
        private T _data;
        private Node<T> _next;

        public Node()
        {
            /*this.data = Data;
            this.data = Next;*/
        }

        public T Data
        {
            set { this._data = value; }
            get { return _data; }
        }

        public Node<T> Next
        {
            set { this._next = value; }
            get { return _next; }
        }

    }
}
