#region Intro
/*Info
 * Programmer: Charlie Beals
 * Date: 2020-10-07
 * Purpose: Give metrics about geometry
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 8
 */
#endregion
using System;
using System.ComponentModel.DataAnnotations;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print instructions
            Console.WriteLine("Please select a shape");
            Console.WriteLine("circle");
            Console.WriteLine("rectangle");
            Console.WriteLine("cylinder");
            string selectedShape = Console.ReadLine();

            bool validShape = false;

            // Select class based on user input
            // Instantiate class, call Calculate() method
            while (validShape == false)
            {
                switch (selectedShape)
                {
                    case "circle":
                        validShape = true;
                        Circle myCircle = new Circle();
                        myCircle.Calculate();
                        break;
                    case "rectangle":
                        validShape = true;
                        Rectangle myRectangle = new Rectangle();
                        myRectangle.Calculate();
                        break;
                    case "cylinder":
                        validShape = true;
                        Cylinder myCylinder = new Cylinder();
                        myCylinder.Calculate();
                        break;
                    default:
                        validShape = false;
                        break;
                }
            }
        }
    }
}
