using SolidPrinciples.OpenClosed.FollowPriciple;
using SolidPrinciples.OpenClosed.FollowPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.FollowPrinciple
{
    public class DatabasePersistance : IInvoicePersistence
    {
        private readonly Invoice invoice;

        public DatabasePersistance(Invoice invoice)
        {
            this.invoice = invoice;
        }
        public void Save(Invoice invoice)
        {
            Console.WriteLine();
        }
    }
}
