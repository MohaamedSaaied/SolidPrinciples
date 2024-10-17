using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.ViolatePrinciple
{
    public class WeatherTraker
    {

        string currentCondition;
        Emailer _emailer;
        public WeatherTraker()
        {
            _emailer = new Emailer();
        }
        public void SetCurrentCondition(string weatherCondition)
        {
            currentCondition = weatherCondition;
            if (weatherCondition == "Cold")
                _emailer.SendEmail("It is Cold Outside ...Take care");
            

        }
    }
}
