#region
/* 
 * Programmer: Charlie Beals
 * Date: 09/26/2020
 * Purpose: Calculate average letter grade score from input
 * Class: CITP 180
 * Assignment: Chapter 6 - Programming Excercise 4
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ScoreAverager
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the Score Averager");

            List<int> listOfScores = new List<int>();

            int scoreNumber = 1;
            bool getNext = true;
            while (getNext == true)
            {
                int inputScore = GetInput(scoreNumber);
                if (inputScore < 101 && inputScore > -1)
                {
                    listOfScores.Add(inputScore);
                    scoreNumber++;
                    getNext = true;
                }
                else if (inputScore == -1)
                {
                    if (listOfScores.Count > 0)
                    {
                        getNext = false;
                    }
                    else
                    {
                        WriteLine("Please enter at least one score before attempting to calculate the average");
                        getNext = true;
                    }
                }
                else
                {
                    WriteLine("Invalid score. Please enter a score between 0 and 100");
                    getNext = true;
                }
            }
            double average = CalculateAverage(listOfScores);
            string letterGrade = CalculateLetterGrade(average);

            WriteLine("Out of " 
                + scoreNumber 
                + " scores entered, your average score was " 
                + average 
                + ", which gives you " 
                + letterGrade 
                + ".");

        }

        static double CalculateAverage(List<int> scores)
        {
            double average = scores.Average();
            WriteLine("The average score is " + average);
            return average;
        }

        static int GetInput(int scoreNumber)
        {
            int result = 0;
            bool validInput = false;
            while (validInput == false)
            {
                WriteLine("Please enter score #" + scoreNumber + ", or enter '-1' to calculate the current average");
                if (int.TryParse(ReadLine(), out result))
                {
                    validInput = true;
                }
                else
                {
                    WriteLine("Invalid input");
                    validInput = false;
                }
            }
            return result;
        }

        static string CalculateLetterGrade(double averageScore)
        {
            string letterGrade;
            if (averageScore >= 90)
            {
                letterGrade = "an A";
            }
            else if (averageScore >= 80)
            {
                letterGrade = "a B";
            }
            else if (averageScore >= 70)
            {
                letterGrade = "a C";
            }
            else if (averageScore >= 60)
            {
                letterGrade = "a D";
            }
            else
            {
                letterGrade = "an F";
            }
            return letterGrade;
        }
    }
}
