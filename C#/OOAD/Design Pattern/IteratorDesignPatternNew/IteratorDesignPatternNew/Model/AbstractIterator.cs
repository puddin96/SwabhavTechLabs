using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternNew.Model
{
    interface AbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
        
    }
}
