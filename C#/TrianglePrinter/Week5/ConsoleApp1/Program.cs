#region About this program

/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/*Info
 * Programmer: Jacob Brookhouse
 * Date: 09/23/2020
 * Purpose: Console App that asks for input, character to display the triangle and the peak size of the triangle, then displays the triangle
 * Class: CITP 180
 * Assignment: Chapter 6 - Programming Excercise 9
 */

#endregion

using System;
using static System.Console;


namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Return to code anchor
            ReturnToMain:

            OutputTriangle(InputCharacter(), InputPeak());

            WriteLine(Environment.NewLine + "Do you want to enter new data for triangle? y/n: ");

            // If input is 'y' then run 'goto ReturnToMain'
            if (ReadLine().Equals("y"))

                // Go to code anchor to run code again
                goto ReturnToMain;

            // If anything else than exit application with success
            else
            {
                Environment.Exit(0);
            }

            ReadLine();

        }

        // Allow user to input a character to be used as the triangle
        public static char InputCharacter()
        {

            string inputValue;
            char character;

            // Ask what chracter you want the triangle to be made up of
            Write("Enter the character to be used to display the  triangle: ");
            // Get input value
            inputValue = ReadLine();
            // Assign input to 'character' 
            character = Convert.ToChar(inputValue);
            // Reutrn character to be used in other method
            return character;

        }

        // Allow user to input an integer for the peak of the triangle
        public static int InputPeak()
        {

            string inputPeak;
            int peak;
            // Ask for basicly how big the triangle wll be
            Write("Enter the integer amount for the peak of the triangle: ");
            // Get input value
            inputPeak = ReadLine();
            // Assign input to 'peak'
            peak = Convert.ToInt32(inputPeak);

            // Just a newline to seperate input with output
            Write(Environment.NewLine);

            // Reutrn peak to be used in other method
            return peak;
            
        }

        // Output the triangle using the users character choice and peak size
        public static void OutputTriangle(char character, int peak)
        {

            int start = 1;
            int finish = (peak - 1);

            // If not equal to peak continue
            while (start != peak)

            {
                // Keep writing character output until amount is less than or equal to start
                // Writes character in ascending
                for (int amount = 1; amount <= start; amount++)

                {

                    Write(character);

                }

                WriteLine();
                start++;

            }

            // Keep writing character output until amount is less than or equal to peak
            // Writes until it hits peak
            for (int amount = 1; amount <= peak; amount++)

            {

                Write(character);

            }

            WriteLine();

            // If not equal to 0 then continue
            while (finish != 0)

            {
                // Keep writing character ouput until amount is less than or equal to finish
                // Writes character in descending
                for (int amount = 1; amount <= finish; amount++)

                {

                    Write(character);

                }

                WriteLine();
                finish--;

            }
        }
    }
}
