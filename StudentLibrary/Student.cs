using System;

namespace StudentLibrary
{
    public class Student
    {
        public int studentId;
        private string studentName;
        private int studentAge;
        public static string universityName;
        static Student()
        {
            Student.universityName = "Delhi University";
        }

        public void acceptDetails()
        {
            Console.Write("Enter Student Id: ");
            this.studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            this.studentName = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            this.studentAge = int.Parse(Console.ReadLine());
        }
        public void displayDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Student Information: ");
            Console.WriteLine("Student Id: {0}", this.studentId);
            Console.WriteLine("Student Name: {0}", this.studentName);
            Console.WriteLine("Student Age: {0}", this.studentAge);
            Console.WriteLine("University Name: {0}", Student.universityName);
        }
    }
}
