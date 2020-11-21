using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace StudentGrades
{
    class Student
    {
        // Create class members
        string student_name;
        double[] student_grades;

        // Default Constructor
        public Student()
        {
        }

        // Parameterized Constructor
        public Student(string name, double[] array)
        {
            student_name = name;
            student_grades = array;
        }

        public double[] StudentGrades
        {
            get
            {
                return student_grades;
            }
        }

        // Average Calculator
        public void PrintAverageScore()
        {
            double sum = 0;
            double average = 0;

            for (int i = 0; i < student_grades.Length; i++)
            {
                sum += student_grades[i];
            }
            average = sum / student_grades.Length;

            WriteLine(student_name + "'s average score is " + average);
        }
    }
}
