/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ObjectOrientedProgramming_Fundamentals
{
    class Student
    {
        private int studentId;
        private string studentName;
        private string studentCourse;

        public Student()
        {
            this.studentId = 100;
            this.studentName = "Anonymous";
        }

        public int StudentId
        {
            get { return studentId;  }
            // set { studentId = value; }
        }
        public string StudentName
        {
            // get { return studentName; }
            set { studentName = value; }
        }
        public string StudentCourse
        {
            get { return studentCourse; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Student Course can't be empty.");
                }
                studentCourse = value;
            }
        }

        public void displayDetails()
        {
            Console.WriteLine("Id: {0} and Name: {1}, Course: {2}", this.studentId, this.studentName, this.studentCourse);
        }
    }
    class PropertiesExample
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // student.StudentId = 101;    // Setter
            Console.WriteLine("Student Id: " + student.StudentId);  // Getter
            student.StudentName = "Gautam Bhalla";  // Setter
            // Console.WriteLine("Student Name: " + student.StudentName); // Getter
            student.StudentCourse = "";
            Console.WriteLine("Student Course: " + student.StudentCourse);
            student.displayDetails();
        }
    }
}
*/