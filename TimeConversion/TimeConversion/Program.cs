/*This application is intended to convert time from hh:mm:ss to total seconds.
 *User will input hours, minutes, and seconds.  
 *The time will be converted to seconds and displayed.
 *The purpose is to lay the foundatio for a pace calculator.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construct new Time object.
            Time time = new Time();

            //Get user input for hours, minutes, and seconds.
            Console.Write("Enter hours: ");
            time.Hours = double.Parse(Console.ReadLine()); //Probably need to use TryParse which returns a bool for exception handling purposes.

            Console.Write("Enter minutes: ");
            time.Minutes = double.Parse(Console.ReadLine()); //Need to add exception handling.

            Console.Write("Enter seconds: ");
            time.Seconds = double.Parse(Console.ReadLine()); //Need to add exception handling.

            Console.Write("Total seconds: ");
            Console.WriteLine(time.ToSeconds(time.Hours, time.Minutes, time.Seconds));
            
        }
    }
}
