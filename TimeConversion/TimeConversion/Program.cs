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
            bool success = true; //flag used for exception handling.
            Time time = new Time();

            //Input hours.
            Console.Write("Enter hours: "); 
            do
            {
                try
                {
                    time.Hours = double.Parse(Console.ReadLine());
                    success = true;
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("Enter hours: ");
                    success = false;
                }
            } while (!success);
            
            //Input minutes.
            Console.Write("Enter minutes: ");
            do
            {
                try
                {
                    time.Minutes = double.Parse(Console.ReadLine());
                    success = true;
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("Enter minutes: ");
                    success = false;
                }
            } while (!success);

            //Input seconds.
            Console.Write("Enter seconds: ");
            do
            {
                try
                {
                    time.Seconds = double.Parse(Console.ReadLine());
                    success = true;
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("Enter seconds: ");
                    success = false;
                }
            } while (!success);

            //Output total seconds.
            Console.Write("Total seconds: ");
            Console.WriteLine(time.ToSeconds(time.Hours, time.Minutes, time.Seconds));
            
        }
    }
}
