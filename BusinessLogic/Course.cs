using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        public Course(string courseName)
        {         
            CourseName = courseName;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; } = "STAFF";

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName 
        {
            get { return CourseName; }
            set
            {
                CourseName = value ?? throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get { return NumberOfCredits; }
            set
            {
                if(value >= 30 || value < 5)
                {
                    throw new ArgumentException();
                }
                NumberOfCredits = value;
            }
        }

    }
}
