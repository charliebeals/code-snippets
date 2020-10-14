using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GeometryCalculator
{
    class Cylinder
    {
        // Set shape parameters
        private double radius;
        private double height;

        // Default constuctor
        public Cylinder()
        {
        }

        // Main Calculate Method
        public void Calculate()
        {
            // Get measurements from the user
            radius = PromptForDouble("the radius");
            height = PromptForDouble("the height");

            // Print other measurements using calculator methods
            WriteLine("The surface area of the Cylinder is " + Math.Round(CalculateCylinderArea(radius, height),2));
            WriteLine("The volume of the Cylinder is " + Math.Round(CalculateVolume(radius, height),2));
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
        private double CalculateCylinderArea(double radius, double height)
        {
            double baseArea = CalculateBaseArea(radius) * 2;
            double sideArea = CalculateBasePerimeter(radius) * height;
            double totalSurfaceArea = baseArea + sideArea;
            return totalSurfaceArea;
        }
        private double CalculateVolume(double radius, double height)
        {
            double baseArea = CalculateBaseArea(radius);
            double volume = baseArea * height;
            return volume;
        }

        // Methods to calculate measurements on the base of the shape
        private double CalculateBasePerimeter(double radius)
        {
            double pi = Math.PI;
            double perimeter = 2 * pi * radius;
            return perimeter;
        }
        private double CalculateBaseArea(double radius)
        {
            double pi = Math.PI;
            double area = pi * radius * radius;
            return area;
        }
    }
}
