using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.FollowPrinciple
{
    public class WeatherTraker
    {
        INotifier _notifier;
        string currentCondition;

        public WeatherTraker(INotifier notifier)
        {
            _notifier = notifier;
        }
        public void SetCurrentCondition(string weatherCondition)
        {
            currentCondition = weatherCondition;
            if (weatherCondition == "Cold")
               _notifier.AlertWeatherConditions("It is Cold Outside ...Take care");


        }
    }
}
