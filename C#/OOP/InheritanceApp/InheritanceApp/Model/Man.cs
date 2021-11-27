using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Man 
    {
        public void Read()
        {
            Console.WriteLine("Man is Reading");
        }

        public void Play()
        {
            Console.WriteLine("Man is Playing");
        }

        public void Walk()
        {
            Console.WriteLine("Man is Walking");
        }

        public virtual void Jump()
        {
        }
    }
}
