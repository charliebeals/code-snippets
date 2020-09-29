using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week_5
{
    class PromptUser
    {
        public double GetDoubleFromUser(string value)
        {
            // Initialize output object
            double result;

            // Get initial input from user
            WriteLine("Please enter the " + value + " in square cm");
            string input = ReadLine();

            // If input is not valid, ask again and continue asking until it is valid.
            // Valid input will succeed the double.TryParse() test.
            while(!double.TryParse(input, out result))
            {
                WriteLine("Invalid input, please try again");
                WriteLine("Please enter the " + value + " in square cm");
                input = ReadLine();
            }
            return result;
        }
    }
}
