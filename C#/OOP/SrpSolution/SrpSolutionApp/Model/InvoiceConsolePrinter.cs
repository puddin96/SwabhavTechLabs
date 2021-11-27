using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrpSolutionApp.Model;

namespace SrpSolutionApp.Model
{
    class InvoiceConsolePrinter
    {

        public InvoiceConsolePrinter(Invoice I)
        {
            Print(I);
        }
        public void Print(Invoice I)
        {
            Console.WriteLine("Invoice Id: {0}", I.Id);
            Console.WriteLine("Invoice Description: {0}", I.Description);
            Console.WriteLine("Invoice Amount: {0}", I.Amount);
            Console.WriteLine("Invoice GST tax: {0}%", I.Tax);
            Console.WriteLine("Invoice Discount: {0}%", I.Discount);
            Console.WriteLine("Discounted amount: {0}", I.CalculateDiscount());
            Console.WriteLine("Tax amount: {0}", I.CalculateTax());
            Console.WriteLine("Final amount: {0}", I.CalculateFinalAmount());
        }
    }
}
