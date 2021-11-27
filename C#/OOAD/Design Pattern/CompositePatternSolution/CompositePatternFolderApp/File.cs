using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp
{
    public class File : IStorageItem
    {
        private string _name;
        private string _size;

        public File(string Name, string Size)
        {
            this._name = Name;
            this._size = Size;
        }
            
        public void Display()
        {
            Console.WriteLine("  " + _name + " | " + _size);
        }
    }
}
