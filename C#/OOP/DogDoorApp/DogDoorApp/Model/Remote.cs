using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    class Remote
    {
        private DogDoor _door;

        public Remote(DogDoor door)
        {
            this._door = door;
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button.....");
            if (_door.IsOpen.Equals(true))
            {
                _door.Close();
            }
            else
            {
                _door.Open();
            }
        }
    }
}
