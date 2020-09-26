using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week_5
{
    class PromptUser
    {
        public string GetStringFromUser (string value)
        {
            WriteLine("Please enter the " + value + " in square cm");
            string userValue = ReadLine();
            return userValue;
        }
        public int GetIntFromUser(string value)
        {
            WriteLine("Please enter the " + value + " in square cm");
            int userValue = Convert.ToInt32(ReadLine());
            return userValue;
        }
    }
}
