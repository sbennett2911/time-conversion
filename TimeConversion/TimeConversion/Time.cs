using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Time
    {
        //properties
        public double Hours { get; set; }
        public double Minutes { get; set; }
        public double Seconds { get; set; }


        //methods
        public double ToSeconds(double h, double m, double s)
        {
            double totalSeconds = 0.0;
            double convertedHours = 0.0;
            double convertedMinutes = 0.0;
            
            //convert hours to seconds
            convertedHours = h * 3600;

            //convert minutes to seconds
            convertedMinutes = m * 60;

            //add seconds together from input to find total seconds
            totalSeconds = convertedHours + convertedMinutes + s;

            return totalSeconds;
        }
    }
}
