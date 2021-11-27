using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder Movie1 = new Folder("Movies");
            Movie1.AddChild(new File("Tashan", "850mb"));
            Movie1.AddChild(new File("Sahoo", "950mb"));

            Folder Movies2 = new Folder("Horror");
            Movies2.AddChild(new File("Conjuring", "1.5gb"));
            Movie1.AddChild(Movies2);
            Movie1.Display();
        }
    }
}
