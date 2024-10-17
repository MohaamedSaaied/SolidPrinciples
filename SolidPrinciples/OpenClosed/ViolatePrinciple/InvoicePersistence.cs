using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.ViolatePrinciple
{
    public class InvoicePersistence
    {
        private readonly Invoice invoice;

        public InvoicePersistence(Invoice invoice)
        {
            this.invoice = invoice;
        }
        public void SaveToFile(string filename)
        => Console.WriteLine("File Saved !");
        public void SaveToDatabase()
        => Console.WriteLine("File Saved To Database!");
    }
}
