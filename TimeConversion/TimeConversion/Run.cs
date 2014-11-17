using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Run
    {
        public double Distance { get; set; }
        public double Pace { get; set; }

        public string CalculatePace(double dist, double time)
        {
            double hours = 0.0;
            double minutes = 0.0;
            double seconds = 0.0;
            double secondsPerMile = 0.0;
            string pace = "";

            //time per mile
            secondsPerMile = time / dist;

            
            /*Break down secondsPerMile into hh:mm:ss format.*/
            
            hours = secondsPerMile % 3600; //extract number of hours from secondsPerMile.
            secondsPerMile = secondsPerMile - (hours * 3600); //subtract number of hours in seconds from secondsPerMile.

            minutes = secondsPerMile % 60; //extract number of minutes from secondsPerMile.
            secondsPerMile = secondsPerMile - (minutes * 60); //subtrat number of minutes in seconds from secondsPerMile.

            seconds = secondsPerMile; //these are the remaining seconds after extracting hours and minutes from secondsPerMile.


            /*Return a string that diplays secondsPerMile in hh:mm:ss per mile format*/
            return pace = hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString() + " per " + "mile";
        }
    }
}
