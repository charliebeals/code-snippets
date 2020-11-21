using System;
using static System.Console;

namespace RandomNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RandomNUmberArray machine");

            // Get size of the 2D array from user
            int arrayRows = PromptForInt("Number of rows");
            int arrayColumns = PromptForInt("Number of columns");

            // Create array
            int[,] myArray = new int[arrayRows, arrayColumns];

            // Fill with random numbers
            // For each row...
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                // for each column...
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = GetRandomNumber();
                }
            }

            // Determine largest value

            int maxValue = 0;
            int indexRow = 0;
            int indexColumn = 0;

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (myArray[i, j] > maxValue)
                    {
                        maxValue = myArray[i, j];
                        indexColumn = j;
                        indexRow = i;
                    }
                }
            }

            // Display index where largest value is stored

            WriteLine("The largest value (" + maxValue + ") is stored in [" + indexRow + "," + indexColumn + "].");

            // Display all values

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                string thisLine = "";
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    int intValue = myArray[i, j];
                    string stringValue = intValue.ToString();

                    // Create padding for display
                    string padding = " ";
                    int stringLength = stringValue.Length;
                    if (stringLength == 1)
                    {
                        padding = "   ";
                    }
                    else if (stringLength == 2)
                    {
                        padding = "  ";
                    }
                    thisLine += stringValue + padding;
                }
                WriteLine(thisLine);
            }
        }

        public static int PromptForInt(string key)
        {
            int value = 0;
            bool enterAgain = true;
            while (enterAgain == true)
            {
                string inValue;
                Write("Please enter " + key + ": ");
                inValue = ReadLine();
                if (int.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid int value");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }

        public static int GetRandomNumber()
        {
            Random r = new Random();
            return r.Next(0, 101);
        }
    }
}
