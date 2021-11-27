using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class ProductDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Data Created");
        }

        public void Delete()
        {
            Console.WriteLine("Data Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Data Read");
        }

        public void Update()
        {
            Console.WriteLine("Data Updated");
        }
    }
}
