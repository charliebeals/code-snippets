using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5
{
    class Rectangle
    {
        public double GetArea()
        {
            //Initialize PropmtUser() class
            PromptUser promptUser = new PromptUser();

            // Ask user for the length and width. The PropmtUser.GetDoubleFromUser() method contains logic that will only accept a double-type.
            double length = promptUser.GetDoubleFromUser("length");
            double width = promptUser.GetDoubleFromUser("width");

            // Do math, return result
            double area = Convert.ToDouble(length * width);
            return area;
        }
    }
}
