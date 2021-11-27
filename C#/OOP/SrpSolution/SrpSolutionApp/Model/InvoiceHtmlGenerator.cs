using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpSolutionApp.Model
{
    class InvoiceHtmlGenerator
    {
        public void SaveInvoice(Invoice invoice)
        {
            string Html = "<html> <body> <table> <th> Invoice Detatils </th>";
            Html += "<tr> ";
            Html += "<td> Invoice ID :</td>";
            Html += "<td> " + invoice.Id + "</td>";
            Html += "</tr>";

            Html += "<tr> ";
            Html += "<td> Descrption :</td>";
            Html += "<td> " + invoice.Description + "</td>";
            Html += "</tr>";

            Html += "<tr> ";
            Html += "<td> Amount :</td>";
            Html += "<td> " + invoice.Amount + "</td>";
            Html += "</tr>";

            Html += "<tr> ";
            Html += "<td> Discount </td>";
            Html += "<td> " + invoice.Discount + " % </td>";
            Html += "</tr>";

            Html += "<tr> ";
            Html += "<td> Tax </td>";
            Html += "<td> " + invoice.Tax + "% </td>";
            Html += "</tr>";

            Html += "<tr> ";
            Html += "<td> Discount Amount :</td>";
            Html += "<td> " + invoice.CalculateDiscount() + "</td>";
            Html += "</tr>";

            Html += "<tr> ";
            Html += "<td> Tax Amount :</td>";
            Html += "<td> " + invoice.CalculateTax() + "</td>";
            Html += "</tr>";

            Html += "<tr> ";
            Html += "<td> Final Price </td>";
            Html += "<td> " + invoice.CalculateFinalAmount() + "</td>";
            Html += "</tr>";

            Html += "</table>";
            Html += "</body>";
            Html += "</html>";

            File.WriteAllText("E:\\SwabhavTech\\C#\\OOP\\SrpSolution\\Invoice.html", Html);


        }
    }
}
