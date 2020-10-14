using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GeometryCalculator
{
    class Rectangle
    {
        // Set shape parameters
        private double length;
        private double width;

        // Default constructor
        public Rectangle()
        {
        }

        // Main calculate method
        public void Calculate()
        {
            // Get length and width from user
            length = PromptForDouble("the length");
            width = PromptForDouble("the width");

            // Print other measurements using calculator methods
            WriteLine("The perimeter of the rectangle is " + Math.Round(CalculatePerimeter(length, width),2));
            WriteLine("The area of the rectangle is " + Math.Round(CalculateArea(length, width),2));
            WriteLine("The diagonal length of the rectangle is " + Math.Round(CalculateDiagonal(length, width),2));
        }

        // Input Method with check to confirm input is type Double
        public static double PromptForDouble(string key)
        {
            double value = 0;
            bool enterAgain = true;
            while (enterAgain == true)
            {
                string inValue;
                Write("Please enter " + key + ": ");
                inValue = ReadLine();
                if (double.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid double value");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }

        // Methods to calculate other measurements
        private double CalculatePerimeter(double length, double width)
        {
            return (length * 2) + (width * 2);
        }
        private double CalculateArea(double length, double width)
        {
            return length * width;
        }
        private double CalculateDiagonal(double length, double width)
        {
            double hypo = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));
            return hypo;
        }
    }
}
