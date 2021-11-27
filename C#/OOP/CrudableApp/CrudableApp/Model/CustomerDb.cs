using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    abstract class  CustomerDb : ICrudable
    {
        public void Create()
        {

        }
        public void Read()
        {

        }
        public abstract void Delete();
        public abstract void Update();
        
    }
}
