using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    class DogDoor
    {
        private bool _open;
        public DogDoor()
        {
            this._open = false;
        }
        public void Open()
        {
            Console.WriteLine("The dog door is open");
            _open = true;
        }
        public void Close()
        {
            Console.WriteLine("The dog door is closes.");
            _open = false;
        }
        public bool IsOpen
        {
            get { return _open; }
        }
    }
}
