#region About this program

/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/*Info
 * Programmer: Jacob Brookhouse
 * Date: 09/15/2020
 * Purpose: Enter height and weight to calculate your BMI, choose from metric or imperial systems.
 *
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 3
 */

#endregion


using System;
using System.Diagnostics;
using static System.Console;

namespace ConsoleApp10
{
    // This main program class is to display output and which system to use, nothing more
    class Program
    {
        static void Main(string[] args)
        {
            // Title of console window
            Title = "BMI Calculator";
            

            // Create new instances for each calculator
            // Used seperate files for each class
            BMICalculatorImperial outputBMIImperial = new BMICalculatorImperial();
            BMICalculatorMetric outputBMIMetric = new BMICalculatorMetric();
            
            // Return to code anchor
            ReturnToMain:

            // Inform and instruct user (I need to start using "\r\n" for new line)
            Write(Environment.NewLine + "Welcome to the Body Mass Index (BMI) Calculator!" + Environment.NewLine);
            Write(Environment.NewLine + "This calculator displays your BMI based on the Imperial or Metric systems." + Environment .NewLine +
                "We will ask for your weight and height." + Environment .NewLine +
                "To continue please choose what system you want to use! " + Environment.NewLine + Environment.NewLine +
                "Type 'i' for Imperial or 'm' for Metric, then press 'enter'");

            // Get input
            string descison = ReadLine();

            // If 'i' then use Imperial system and display output by calling 'outputBMIImperial'
            if (descison == "i")

                Write(DisplayOutput(outputBMIImperial.CalculateBMI()));

            // If 'm' then use Metric system and display output by calling 'outputBMIMetric'
            else if (descison == "m")
            {

                Write(DisplayOutput(outputBMIMetric.CalculateBMI()));

            }
            // If anything else then display error and return to code anchor so user can choose system again.
            else
                Write("There was an error or you chose the wrong system! Please restart...");

            // Ask to enter new data or exit?
            Write(Environment.NewLine + "Do you want to enter new data? y/n: ");
            // If input is 'y' then run 'goto ReturnToMain'
            if (ReadLine().Equals("y"))

                // Go to code anchor to run code again
                goto ReturnToMain;
            
            // If anything else than exit application with success
            else
            {
                Environment.Exit(0);
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
}
