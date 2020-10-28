using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysEnrollment
{
    class Course
    {
        // Create class members
        private string course_name;
        private int current_enrollment;
        private int max_enrollment;

        // Default Constructor
        public Course()
        {
        }

        // Property Accessors
        public string Course_Name
        {
            get
            {
                return course_name;
            }
            set
            {
                course_name = value;
            }
        }
        public int Current_Enrollment
        {
            get
            {
                return current_enrollment;
            }
            set
            {
                current_enrollment = value;
            }
        }
        public int Max_Enrollment
        {
            get
            {
                return max_enrollment;
            }
            set
            {
                max_enrollment = value;
            }
        }

        // Calculate the number of seats remaining in the class
        public int Remaining_Seats()
        {
            int remaining_seats = max_enrollment - current_enrollment;
            return remaining_seats;
        }

        // Override ToString() method with a string containing information about the course
        public override string ToString()
        {
            string formatted_output = "\n------" + course_name + "------\n Current Enrolled: " + current_enrollment + "\n Open Seats: " + Remaining_Seats() + "\n-----------------";
            return formatted_output;
        }
    }
}
