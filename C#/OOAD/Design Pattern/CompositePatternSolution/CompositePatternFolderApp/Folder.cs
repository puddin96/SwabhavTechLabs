using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp
{
    public class Folder : IStorageItem
    {
        private string _name;
        private List<IStorageItem> S1 = new List<IStorageItem>();

        public Folder(string Name)
        {
            this._name = Name;
        }

        public void AddChild(IStorageItem storage)
        {
            S1.Add(storage);
        }
        public void Display()
        {
            Console.WriteLine(_name);
            foreach(IStorageItem storageItem in S1)
            {
                storageItem.Display();
            }
        }
    }
}
