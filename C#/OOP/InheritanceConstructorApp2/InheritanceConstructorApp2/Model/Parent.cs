using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp2.Model
{
    class Parent
    {
        int _foo;

        public Parent(int foo)
        {
            _foo = foo;
        }

        public int Foo
        {
            get
            {
                return _foo;
            }
        }
    }
}
