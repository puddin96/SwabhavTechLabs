using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrpSolutionApp.Model;

namespace SrpSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "One Plus 6T", 45000, 10f, 25f);
            InvoiceHtmlGenerator htmlGenerator = new InvoiceHtmlGenerator();
            htmlGenerator.SaveInvoice(invoice);
        }
    }
}
