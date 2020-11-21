using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Transactions;
using static System.Console;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get number of assignments from user
            int number_of_assignments = PromptForInt("the number of assignments");

            // Create an arrayList
            ArrayList list_of_students = new ArrayList();

            // Get students from user
            bool enter_another = true;
            while (enter_another == true)
            {
                list_of_students.Add(GetStudent(number_of_assignments));
                enter_another = GetAnotherStudent();
            }

            // Print average grades
            for (int i = 0; i < list_of_students.Count; i++)
            {
                Student thisStudent = (Student) list_of_students[i];
                thisStudent.PrintAverageScore();
            }

            // Print averages per assignment
            PrintAssignmentAverages(list_of_students, number_of_assignments);
        }

        // Prompt for interger with verification
        public static int PromptForInt(string key)
        {
            // Initialize values
            int value = 0;
            bool enterAgain = true;

            // Confirm entered value is a double before accepting it, otherwise continue to ask the user
            while (enterAgain == true)
            {
                string inValue;
                Write("Please enter " + key + ": ");
                inValue = ReadLine();
                if (int.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid double value");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }
        
        // Prompt for double with verification
        public static double PromptForDouble(string key)
        {
            // Initialize values
            double value = 0;
            bool enterAgain = true;

            // Confirm entered value is a double before accepting it, otherwise continue to ask the user
            while (enterAgain == true)
            {
                string inValue;
                Write("Please enter " + key + ": ");
                inValue = ReadLine();
                if (double.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid double value");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }

        // Get student from user
        public static Student GetStudent(int number_of_assignments)
        {
            // Get student name
            Write("Enter student name: ");
            string student_name = ReadLine();

            // Get each score from the user, add to array
            double[] student_grades = new double[number_of_assignments];
            for (int i = 0; i < number_of_assignments; i++)
            {
                string key = "score for assignment " + (i + 1);
                double inValue = PromptForDouble(key);
                student_grades[i] = inValue;
            }

            // Create student object, passing in student name and grade array
            Student thisStudent = new Student(student_name, student_grades);

            // Return Student object
            return (thisStudent);
        }

        // Determine if we should ask for another user
        public static bool GetAnotherStudent()
        {
            Write("Enter \"Y\" to enter another student or \"N\" to quit: ");
            string inValue = ReadLine();
            WriteLine("");
            bool returnValue;

            if (inValue == "Y")
            {
                returnValue = true;
            }
            else
            {
                returnValue = false;
            }

            return (returnValue);
        }

        // Print the average score per user
        public static void PrintAssignmentAverages(ArrayList list_of_students, int number_of_assignments)
        {
            // For each assignment...
            for (int i = 0; i < number_of_assignments; i++)
            {
                double sum = 0;
                double average = 0;

                // For each student...
                for (int j = 0; j < list_of_students.Count; j++)
                {                    
                    Student thisStudent = (Student)list_of_students[j];

                    sum += thisStudent.StudentGrades[i];
                }

                // Calculate Average
                average = sum / number_of_assignments;

                // Print Result
                WriteLine("The average score for assignment " + (i + 1) + " is " + average);
            }
        }
    }
}
