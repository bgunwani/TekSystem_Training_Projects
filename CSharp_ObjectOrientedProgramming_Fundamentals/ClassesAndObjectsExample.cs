/*using System;

namespace CSharp_ObjectOrientedProgramming_Fundamentals
{
    class Student
    {
        // Data Members (Instance Data Members): 
        public int studentId;
        private string studentName;
        private int studentAge;
        // Static Data Members (Class Data Members):
        public static string universityName = "Delhi University";

        // Member Function (Methods)
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
            Console.WriteLine("Student Information: ");
            Console.WriteLine("Student Id: {0}", this.studentId);
            Console.WriteLine("Student Name: {0}", this.studentName);
            Console.WriteLine("Student Age: {0}", this.studentAge);
            Console.WriteLine("University Name: {0}", Student.universityName);
        }
    }
    class MainEntry
    {
        static void Main(string[] args)
        {

            // Student student = new Student();
            Student student;    // Creating a reference variable
            student = new Student();    // Creating an object of Student Class
            student.acceptDetails();
            student.displayDetails();

            Student.universityName = "BVIMR";

            Student student1 = new Student();
            student1.acceptDetails();
            student1.displayDetails();

            Student student2 = new Student();
            student2.acceptDetails();
            student2.displayDetails();
        }
    }
}
*/