using System;
using static System.Console;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {

            double exemptionValue = 25000.00;
            double schoolIncrease = 0.027;
            double millagePerGrand = 10.03;

            // Get assessed value of house
            double assessedValue = GetAssessedValue();

            // Add increase for school budget
            double ValueAfterIncrease = AddSchoolIncrease(assessedValue, schoolIncrease);

            // Subtract exemption amount
            double ValueAfterExemption = SubtractExemption(ValueAfterIncrease, exemptionValue);

            // Calculate final taxes owed
            double tax = CalculateTaxes(ValueAfterExemption, millagePerGrand);

            // Display output
            DisplayOutput(assessedValue, ValueAfterIncrease, ValueAfterExemption, tax);
        }

        static double GetAssessedValue()
        {
            WriteLine("Enter the home address: ");
            string address = ReadLine();
            WriteLine("Enter the assessed value of the house: ");
            double AssessedValue = Convert.ToDouble(ReadLine());
            return AssessedValue;
        }

        static double SubtractExemption(double assessedValue, double exemptionValue)
        {
            double ValueAfterExemption = assessedValue - exemptionValue;
            return ValueAfterExemption;
        }

        static double AddSchoolIncrease(double assessedValue, double increaseRate)
        {
            double increaseAmmount = assessedValue * increaseRate;
            double ValueAfterIncrease = assessedValue + increaseAmmount;
            return ValueAfterIncrease;
        }

        static double CalculateTaxes(double assessedValue, double millage)
        {
            double baseValue = assessedValue / 1000;
            double tax = baseValue * millage;
            return tax;
        }

        static void DisplayOutput(double assessedValue, double ValueAfterIncrease, double ValueAfterExemption, double tax)
        {
            WriteLine("Assessed value of the house is {0:C}", assessedValue);
            WriteLine("After increase for schools, the assessed value is {0:C}", ValueAfterIncrease);
            WriteLine("After the local exemption, the assessed value is {0:C}", ValueAfterExemption);
            WriteLine("taxes owed is {0:C}", tax);
        }
    }
}
