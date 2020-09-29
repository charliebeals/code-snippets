#region
/*Info
 * Programmer: Charlie Beals
 * Date: 2020-09-22
 * Purpose: Calculate area of shapes
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 6
 */
#endregion

using System;
using static System.Console;

namespace Week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the area calculator!");

            // Local method below, not set aside for program reasons, simply for readability
            string shape = GetShape();

            // Initialize output object
            double area = 0;

            // GetShape() can only return one of three values. Those are parsed by this switch statement. A default is defined in case of a bug.
            // Each case will create an instance of the corresponding object, run that object's GetArea() method, then return the value in the 'area' object.
            switch(shape)
            {
                case "circle":
                    Circle newCircle = new Circle();
                    double circleArea = newCircle.GetArea();
                    area = circleArea;
                    break;
                case "rectangle":
                    Rectangle newRectangle = new Rectangle();
                    double rectangleArea = newRectangle.GetArea();
                    area = rectangleArea;
                    break;
                case "cylinder":
                    Cylinder newCylinder = new Cylinder();
                    double cylinderArea = newCylinder.GetArea();
                    area = cylinderArea;
                    break;
                default:
                    WriteLine("No shape Selected");
                    break;
            }
            // Print output
            WriteLine("");
            WriteLine("The area of the " + shape + " is " + area + " square centimeters");
        }

        static string GetShape()
        {
            bool validShape = false;
            string shape = "";

            // Until a valid shape is entered, continue asking for the user to select a shape
            while (validShape == false)
            {
                // Print list of options to chose from
                WriteLine("Please select a shape from the below menu to find the area of");
                WriteLine("");
                WriteLine(" circle");
                WriteLine(" rectangle");
                WriteLine(" cylinder");

                // Determine if option is valid, cycle back to top of while loop if not. Otherwise return to main.
                shape = ReadLine();
                if (shape == "circle" || shape == "rectangle" || shape == "cylinder")
                {
                    validShape = true;
                }
                else
                {
                    WriteLine("Invalid shape.");
                }
            }
            return shape;
        }
    }
}
