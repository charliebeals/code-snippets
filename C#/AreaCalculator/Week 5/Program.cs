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
            string shape = GetShape();

            int area = 0;

            switch(shape)
            {
                case "circle":
                    Circle newCircle = new Circle();
                    int circleArea = newCircle.GetArea();
                    area = circleArea;
                    break;
                case "rectangle":
                    Rectangle newRectangle = new Rectangle();
                    int rectangleArea = newRectangle.GetArea();
                    area = rectangleArea;
                    break;
                case "cylinder":
                    Cylinder newCylinder = new Cylinder();
                    int cylinderArea = newCylinder.GetArea();
                    area = cylinderArea;
                    break;
                default:
                    WriteLine("No shape Selected");
                    break;
            }
            WriteLine("");
            WriteLine("The area of the " + shape + " is " + area + " square centimeters");
        }

        static string GetShape()
        {
            WriteLine("Welcome to the area calculator!");
            bool validShape = false;
            string shape = "";
            while (validShape == false)
            {
                WriteLine("Please select a shape from the below menu to find the area of");
                WriteLine("");
                WriteLine(" circle");
                WriteLine(" rectangle");
                WriteLine(" cylinder");
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
