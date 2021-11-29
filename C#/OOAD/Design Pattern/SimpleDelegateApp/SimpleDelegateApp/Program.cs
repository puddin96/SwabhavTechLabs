using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage f1;
            f1 = PrintHello;
            f1("Shivam");
            f1 = PrintGoodBye;
            f1("Ben");

            //f1 = PrintFoo;
            Console.WriteLine(" ");
            MessageWizard(f1);
            Console.WriteLine(" ");
            MessageWizard(PrintHello);
            Console.WriteLine(" ");
            MessageWizard(PrintGoodBye);

            DPrintMessage f2 = PrintHello;
            f2 += PrintGoodBye;
            f2 += PrintHello;
            f2 += PrintGoodBye;
            f2("Swabhav Tech");
        }

        static void PrintHello(string name)
        {
            Console.WriteLine("Hello Says {0}", name);
        }

        static void PrintGoodBye(string name)
        {
            Console.WriteLine("GoodBye says {0}", name);
        }

        static void PrintFoo()
        {

        }

        static void MessageWizard(DPrintMessage f)
        {
            Console.WriteLine("Inside MessageWizard");
            f("Champ");
        }
    }
}
