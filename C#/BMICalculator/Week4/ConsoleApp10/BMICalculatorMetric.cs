using System;
using static System.Console;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp10
{
    // This class is used to do all the calculations for Metric
    class BMICalculatorMetric
    {
        public float CalculateBMI()
        {
            // Call methods and assign values then return result
            float heightCM = GetHeight();
            float height = heightCM / 100;
            int weight = GetWeight();
            float rawBMI = (weight) / (height * height);
            float BMI = (float)Math.Round(rawBMI, 2);
            return BMI;
        }
        static int GetHeight()
        {
            // Get user's height
            WriteLine("Please enter your height in cm");
            int height = Convert.ToInt32(ReadLine());
            return height;
        }
        static int GetWeight()
        {
            // Get user's weight
            WriteLine("Please enter your weight in Kg");
            int weight = Convert.ToInt32(ReadLine());
            return weight;
        }
    }
}
