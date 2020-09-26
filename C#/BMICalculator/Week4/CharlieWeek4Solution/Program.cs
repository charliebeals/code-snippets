#region about
/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/*Info
 * Programmer: Charlie Beals
 * Date: 2020-09-16
 * Purpose: Calculate BMI
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 3
 */
#endregion
using System;
using System.Net.NetworkInformation;
using static System.Console;

namespace CharlieWeek4Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user's unit preferences
            WriteLine("Please enter your desired units. Supported options are 'i' for the impreial system and 'm' for the metric system");
            string units = ReadLine();

            // Create BMI object to fill during if loop
            float BMI;

            // Determine which units to use; run the correct calculator
            if (units == "i")
            {
                ImpreialCalculator Calculator = new ImpreialCalculator();
                WriteLine(DisplayOutput(Calculator.CalculateBMI()));
            }
            else if (units == "m")
            {
                MetricCalculator Calculator = new MetricCalculator();
                WriteLine(DisplayOutput(Calculator.CalculateBMI()));
            }
            else
            {
                WriteLine("Invalid unit type");
            }
        }

        static string DisplayOutput(float BMI)
        {
            string weightStatus;
            // Based on the calculated BMI, create a string telling the user their weight status
            if (BMI < 18.5)
            {
                weightStatus = "underweight";
            }
            else if (BMI < 25)
            {
                weightStatus = "normal";
            }
            else if (BMI < 30)
            {
                weightStatus = "overweight";
            }
            else
            {
                weightStatus = "obese";
            }

            string outputString = "Your BMI is " + BMI + ", which is " + weightStatus + ".";
            return outputString;
        }
    }

    class ImpreialCalculator
    {
        public float CalculateBMI()
        {
            int height = GetHeight();
            int weight = GetWeight();
            float BMI = (weight * 703) / (height * height);
            return BMI;
        }
        static int GetHeight()
        {
            //Get user's height
            WriteLine("Please enter your height in inches");
            int height = Convert.ToInt32(ReadLine());
            return height;
        }
        static int GetWeight()
        {
            //Get user's weight
            WriteLine("Please enter your weight in pounds");
            int weight = Convert.ToInt32(ReadLine());
            return weight;
        }
    }

    class MetricCalculator
    {
        public float CalculateBMI()
        {
            float heightCM = GetHeight();
            float height = heightCM / 100;
            int weight = GetWeight();
            float rawBMI = (weight) / (height * height);
            float BMI = (float)Math.Round(rawBMI, 2);
            return BMI;
        }
        static int GetHeight()
        {
            //Get user's height
            WriteLine("Please enter your height in cm");
            int height = Convert.ToInt32(ReadLine());
            return height;
        }
        static int GetWeight()
        {
            //Get user's weight
            WriteLine("Please enter your weight in Kg");
            int weight = Convert.ToInt32(ReadLine());
            return weight;
        }
    }
}
