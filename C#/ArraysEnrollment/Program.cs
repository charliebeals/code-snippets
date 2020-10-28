// Title: ArraysEnrollment
// Programer: Charlie Beals
// Date: 2020-10-26
// Class: C#.NET Programming
// Assignment: Ch 7, Ex 10
using System;

namespace ArraysEnrollment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LCC's course system. ");

            // At compile time, 5 Course objects will be created in an array.
            Course[] myCourses = new Course[5];

            // Set compile-time values
            myCourses[0] = new Course();
            myCourses[0].Course_Name = "CS150";
            myCourses[0].Current_Enrollment = 180;
            myCourses[0].Max_Enrollment = 200;
            myCourses[1] = new Course();
            myCourses[1].Course_Name = "CS250";
            myCourses[1].Current_Enrollment = 21;
            myCourses[1].Max_Enrollment = 30;
            myCourses[2] = new Course();
            myCourses[2].Course_Name = "CS270";
            myCourses[2].Current_Enrollment = 9;
            myCourses[2].Max_Enrollment = 20;
            myCourses[3] = new Course();
            myCourses[3].Course_Name = "CS300";
            myCourses[3].Current_Enrollment = 4;
            myCourses[3].Max_Enrollment = 20;
            myCourses[4] = new Course();
            myCourses[4].Course_Name = "CS350";
            myCourses[4].Current_Enrollment = 20;
            myCourses[4].Max_Enrollment = 20;

            // Print the values for each class
            for (int i = 0; i < myCourses.Length; i++)
            {
                Console.Write(myCourses[i].ToString());
            }

        }
    }
}
