using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5
{
    class Rectangle
    {
        public int GetArea()
        {
            PromptUser promptUser = new PromptUser();

            int length = promptUser.GetIntFromUser("length");
            int width = promptUser.GetIntFromUser("width");
            int area = Convert.ToInt32(length * width);
            return area;
        }
    }
}
