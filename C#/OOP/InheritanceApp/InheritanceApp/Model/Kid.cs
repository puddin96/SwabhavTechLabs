using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Kid : Man
    {
        public override void Jump()
        {
            Console.WriteLine("Kid is Jumping");
        }
    }
}
