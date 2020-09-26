using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5
{
    class Cylinder
    {
        public int GetArea()
        {
            PromptUser promptUser = new PromptUser();
            double pi = Math.PI;

            int height = promptUser.GetIntFromUser("height");
            int radius = promptUser.GetIntFromUser("radius");
            int area = Convert.ToInt32((2 * pi * radius * height) + (pi * (radius * radius)));
            return area;
        }
    }
}
