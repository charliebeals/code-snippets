using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GeometryCalculator
{
    class Circle
    {
        // Set shape parameters
        private double radius;

        // Default constructor
        public Circle()
        {
        }

        // Main calculate method
        public void Calculate()
        {
            // Get radius from user input
            radius = PromptForDouble("the radius");

            // Print other measurements using calculator methods
            WriteLine("The diameter of the circle is " + Math.Round(CalculateDiameter(radius),2));
            WriteLine("The perimeter of the circle is " + Math.Round(CalculatePerimeter(radius),2));
            WriteLine("The area of the circle is " + Math.Round(CalculateArea(radius),2));
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
        private double CalculateDiameter(double radius)
        {
            return radius * 2;
        }
        private double CalculatePerimeter(double radius)
        {
            double pi = Math.PI;
            double perimeter = 2 * pi * radius;
            return perimeter;
        }
        private double CalculateArea(double radius)
        {
            double pi = Math.PI;
            double area = pi * radius * radius;
            return area;
        }
    }
}
