using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceApp;

namespace InheritanceApp.Model
{
    class Boy : Man
    {
        public override void Jump()
        {
            Console.WriteLine("Boy is Jumping");
        }

        public void Play()
        {
            Console.WriteLine("Boy is Playing");
        }


    }
}
