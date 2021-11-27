using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp
{
    [AttributeUsage(AttributeTargets.All)]
    class NeedToRefactor : Attribute
    {
        public string Name { get; set; }

    }
}
