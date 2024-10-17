using SolidPrinciples.OpenClosed.FollowPriciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.FollowPrinciple.Interfaces
{
    public interface IInvoicePersistence
    {
        void Save(Invoice invoice);
    }
}
