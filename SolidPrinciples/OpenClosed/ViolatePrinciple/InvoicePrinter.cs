using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.ViolatePrinciple
{
    public class InvoicePrinter
    {
        private readonly Invoice invoice;

        public InvoicePrinter(Invoice invoice)
        {
            this.invoice = invoice;
        }
        public void PrintInvoice()
            => Console.WriteLine($"Book Name : {invoice.Book.Name}, Book Price :{invoice.Book.Price} Quantity: {invoice.Quantity} Total : {invoice.Total}");
    }
}
