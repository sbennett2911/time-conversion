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

        public string CalculatePace(double dist, double time)
        {
            double secondsPerMile = 0.0;
            string pace = "";

            //Calculate pace in seconds per mile.
            secondsPerMile = time / dist;

            //Format pace into h:m:s.
            TimeSpan t = TimeSpan.FromSeconds(secondsPerMile);
            return pace = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", t.Hours, t.Minutes, t.Seconds) + " per mile";
        }
    }
}
