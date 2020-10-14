// Title: RectangleDrawing
// Programer: Charlie Beals
// Date: 2020-10-14
// Class: C#.NET Programming
// Assignment: Exam 2
using System;
using static System.Console;

namespace RectangleDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("This program draws rectangles based on user input.");

            bool drawAnother = true;

            while (drawAnother == true)
            {
                // Prompt user for input values
                int inputHeight = getInt("height");
                int inputWidth = getInt("width");

                // Instantiate rectangle class
                Rectangle myRectangle = new Rectangle(inputHeight,inputWidth);

                myRectangle.draw();

                Write("Draw another? (Y/N): ");
                string another = ReadLine();
                if (another == "Y" || another == "y")
                {
                    drawAnother = true;
                }
                else
                {
                    drawAnother = false;
                }
            }
        }

        static int getInt(string key)
        {
            bool askAgain = true;
            int returnValue = 0;
            while (askAgain == true)
            {
                Write("Enter the " + key + ": ");
                int value;
                if(int.TryParse(ReadLine(),out value))
                {
                    returnValue = value;
                    askAgain = false;
                }
                else
                {
                    WriteLine("Invalid input.");
                    askAgain = true;
                }
            }

            return returnValue;
        }
    }
}
