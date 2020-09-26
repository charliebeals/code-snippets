using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5
{
    class Circle
    {
        public int GetArea()
        {
            PromptUser promptUser = new PromptUser();
            double pi = Math.PI;

            int radius = promptUser.GetIntFromUser("radius");
            int area = Convert.ToInt32(pi * (radius*radius));
            return area;
        }
    }
}