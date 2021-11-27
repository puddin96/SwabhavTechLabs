using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = Convert.ToInt32(args[0]);
            int SecondNumber = Convert.ToInt32(args[1]);
            int Result = FirstNumber / SecondNumber;
            Console.WriteLine("{0} / {1} = {2}", FirstNumber, SecondNumber, Result);
            //Main(args);
            Console.WriteLine("End of Main");
            Console.ReadLine();
        }
        //System.IndexOutOfRangeException
        //LineNumber 14

        //System.FormatException
        //LineNumber 13

        //OverflowException
        //LineNumber 13

        //DivideByZeroException
        //LineNumber 15


    }
}
