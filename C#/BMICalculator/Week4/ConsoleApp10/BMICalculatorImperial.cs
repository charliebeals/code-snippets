using System;
using static System.Console;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp10
{
    // This class is used to do all the calculations for Imperial
    class BMICalculatorImperial
    {
        public float CalculateBMI()
        {
            // Call methods and assign values then return result
            int height = GetHeight();
            int weight = GetWeight();
            float BMI = (weight * 703) / (height * height);
            return BMI;
        }
        static int GetHeight()
        {
            //Get user's height
            WriteLine("Please enter your height in inches");
            int height = Convert.ToInt32(ReadLine());
            return height;
        }
        static int GetWeight()
        {
            //Get user's weight
            WriteLine("Please enter your weight in pounds");
            int weight = Convert.ToInt32(ReadLine());
            return weight;
        }
    }
}
