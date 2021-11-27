using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPViolation.Model;

namespace LSPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RECTANGLE");
            ShouldNotChangeWidthIfHeightIsModified(new Rectangle(20, 40));
            Console.WriteLine("\nSQUARE");
            ShouldNotChangeWidthIfHeightIsModified(new Square(40));
            Console.ReadKey();
        }

        static void ShouldNotChangeWidthIfHeightIsModified(Rectangle rectangle)
        {
            var before = rectangle.Width;
            rectangle.Height = rectangle.Height + 20;
            var after = rectangle.Width;
            Console.WriteLine(before == after);
            Console.WriteLine("before width : " + before);
            Console.WriteLine("after width  : " + after);
        }
    }
}
