#region about
/*Info
 * Programmer: Charlie Beals
 * Date: 2020-09-17
 * Purpose: Select sport activity based on weather
 * Class: CITP 180
 * Assignment: Exam 1
 */
#endregion
using System;
using System.Diagnostics;
using static System.Console;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the temperature from the user as a number
            WriteLine("Please enter the temperature in degrees Fahrenheit: ");
            int inputTemperature = 0;
            try
            {
                inputTemperature = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException)
            {
                WriteLine("Invalid temperature entered. Exiting application.");
                Environment.Exit(1);
            }
            
            // Get the weather from the user as a single-letter code
            WriteLine("P - Rain/Snow");
            WriteLine("S - Sunny");
            WriteLine("O - Cloudy");
            WriteLine("Please enter a weather code: ");
            string weatherCode = ReadLine();

            // Convert the temperature from a number to a single-letter code
            string tempClass = ConvertTemperature(inputTemperature);

            // Determine activity based on the temperature and weather
            string activity = GetActivity(tempClass, weatherCode);

            // Return string telling the user what they should do today
            WriteLine("Today you should " + activity + ".");
            
        }

        static string ConvertTemperature(int inputTemperature)
        {
            // Initialize local variable
            string tempClass = "";

            // Determine temperature letter-code based on passed in value
            // Also catch temperatures outside of reasonable values
            // Also add additional "danger" temperature classification for extereme temperatures
            if (inputTemperature >150 || inputTemperature < -40)
            {
                WriteLine("Temperature outside of valid range. Exiting application.");
                Environment.Exit(1);
            }
            else if (inputTemperature > 110 || inputTemperature < -10)
            {
                tempClass = "X";
            }
            else if (inputTemperature > 72)
            {
                tempClass = "H";
            }
            else if (inputTemperature >= 60 && inputTemperature <= 72)
            {
                tempClass = "M";
            }
            else if (inputTemperature < 60)
            {
                tempClass = "C";
            }
            return tempClass;
        }

        static string GetActivity(string tempClass, string weatherCode)
        {
            // If user entered invalid weather code, assume cloudy ("O")
            if (weatherCode != "P" && weatherCode != "S" && weatherCode != "O")
            {
                weatherCode = "O";
            }

            // Initialize activity local variable
            string activity = "";

            // Determine correct activity based on passed-in temperature and weather codes
            // activity strings contain the correct verb preceeding the direct object of the final sentence
            if (tempClass == "H")
            {
                if (weatherCode == "P")
                {
                    activity = "play Soccer";
                }
                else if(weatherCode == "S")
                {
                    activity = "go Swimming";
                }
                else if (weatherCode == "O")
                {
                    activity = "play Baseball";
                }
            }
            else if (tempClass == "M")
            {
                if (weatherCode == "P")
                {
                    activity = "play Indoor Basketball";
                }
                else if (weatherCode == "S")
                {
                    activity = "play Tennis";
                }
                else if (weatherCode == "O")
                {
                    activity = "play Outdoor Basketball";
                }
            }
            else if (tempClass == "C")
            {
                if (weatherCode == "P")
                {
                    activity = "go Sledding";
                }
                else if (weatherCode == "S")
                {
                    activity = "go Running";
                }
                else if (weatherCode == "O")
                {
                    activity = "play Hockey";
                }
            }
            else if (tempClass == "X")
            {
                activity = "stay inside";
            }

            return activity;
        }
    }
}
