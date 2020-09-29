using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5
{
    class Cylinder
    {
        public double GetArea()
        {
            //Initialize PropmtUser() class
            PromptUser promptUser = new PromptUser();

            // Get value of pi
            double pi = Math.PI;

            // Ask user for the radius. The PropmtUser.GetDoubleFromUser() method contains logic that will only accept a double-type.
            double height = promptUser.GetDoubleFromUser("height");
            double radius = promptUser.GetDoubleFromUser("radius");

            // Do math, return result
            double area = Convert.ToDouble((2 * pi * radius * height) + (pi * (radius * radius)));
            return area;
        }
    }
}
