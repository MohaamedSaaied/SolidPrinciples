using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.FollowPrinciple
{
    public interface INotifier
    {
        void AlertWeatherConditions(string weatherConditions);
    }
}
