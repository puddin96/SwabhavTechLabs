using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudableApp.Model;

namespace CrudableApp.Model
{
    public interface ICrudable
    {
        void Create();
        void Read();
        void Update();
        void Delete();
        
    }
}
