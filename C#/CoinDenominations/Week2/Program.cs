/* Written by:    Charlie Beals
 * Date Created:  2020/08/29
 * Purpose:       To perform basic math in a C# console program.
 * Class:         CITP 180
 * Assignment:    Chapter 2, Excercise 4
 */
using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set input ammount
            int inputCents = 27;

            // Set denomination constants
            const int quarterValue = 25;
            const int dimeValue = 10;
            const int nickelValue = 5;
            const int pennyValue = 1;

            // Set counters
            int numQuarters = 0;
            int numDimes = 0;
            int numNickels = 0;
            int numPennies = 0;

            // Set while loop controllers
            bool moreQuarters = true;
            bool moreDimes = true;
            bool moreNickels = true;
            bool morePennies = true;

            // Print initial amount
            double inputDollars = (double)inputCents / 100;
            Console.WriteLine("Amount of money input: {0:C}", inputDollars);

            // Calculate values
            // I feel that there is a more intuitive solution that would only run one WHILE loop, changing the values it's checking for and updating ones the IF is false...
            while (moreQuarters == true)
            {
                if ((inputCents / quarterValue) >= 1)
                {
                    numQuarters++;
                    inputCents -= quarterValue;
                }
                else
                {
                    moreQuarters = false;
                }
            }
            while (moreDimes == true)
            {
                if ((inputCents / dimeValue) >= 1)
                {
                    numDimes++;
                    inputCents -= dimeValue;
                }
                else
                {
                    moreDimes = false;
                }
            }
            while (moreNickels == true)
            {
                if ((inputCents / nickelValue) >= 1)
                {
                    numNickels++;
                    inputCents -= nickelValue;
                }
                else
                {
                    moreNickels = false;
                }
            }
            while (morePennies == true)
            {
                if ((inputCents / pennyValue) >= 1)
                {
                    numPennies++;
                    inputCents -= pennyValue;
                }
                else
                {
                    morePennies = false;
                }
            }

            // Print results of calculations
            Console.WriteLine("Number of Quarters: " + numQuarters);
            Console.WriteLine("Number of Dimes: " + numDimes);
            Console.WriteLine("Number of Nickels: " + numNickels);
            Console.WriteLine("Number of Pennies: " + numPennies);
        }
    }
}
