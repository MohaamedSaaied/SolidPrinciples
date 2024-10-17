using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.FollowPrinciple
{
    public class Sms : INotifier
    {
        public void AlertWeatherConditions(string weatherConditions)
        {
            throw new NotImplementedException();
        }
    }
}
