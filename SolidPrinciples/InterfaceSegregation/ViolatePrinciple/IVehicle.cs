using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.ViolatePrinciple
{
    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
        void Drive();
        void Fly();
    }
}
