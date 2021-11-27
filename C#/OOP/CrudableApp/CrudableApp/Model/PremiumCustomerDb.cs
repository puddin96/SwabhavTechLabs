using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class PremiumCustomerDb : CustomerDb
    {
        public override void Delete()
        {
            Console.WriteLine("Data Deleted");
        }

        public override void Update()
        {
            Console.WriteLine("Data Updated");
        }
    }
}
