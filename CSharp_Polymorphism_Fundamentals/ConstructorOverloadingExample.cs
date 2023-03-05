using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Polymorphism_Fundamentals
{
    class Student : ICloneable
    {
        // Data Members (Instance Data Members): 
        private int studentId;
        private string studentName;
        private int studentAge;
        private static string universityName;

        // private Student() { }
        public Student()
        {
            this.studentId = 101;
            this.studentName = "Anonymous";
            this.studentAge = 18;
        }

        static Student()
        {
            Student.universityName = "Delhi University";
        }

        public Student(int studentId, string studentName, int studentAge)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentAge = studentAge;
        }

        public Student(Student student)
        {
            this.studentId = student.studentId;
            this.studentName = student.studentName;
            this.studentAge = student.studentAge;
        }

        public void displayDetails()
        {
            Console.WriteLine("Student Information: ");
            Console.WriteLine("Student Id: {0}", this.studentId);
            Console.WriteLine("Student Name: {0}", this.studentName);
            Console.WriteLine("Student Age: {0}", this.studentAge);
            Console.WriteLine("University Name: {0}", Student.universityName);
        }

        public virtual object Clone()
        {
            // Memberwise Clonning
            return this.MemberwiseClone();
        }
    }
    class ConstructorOverloadingExample
    {
        /*static void Main(string[] args)
        {

            Student student1 = new Student();
            student1.displayDetails();

            Student student2 = new Student(1002, "Smith", 23);
            student2.displayDetails();

            Student student3 = new Student(student2);
            student3.displayDetails();

            Student student4 = student3;
            student4.displayDetails();
        }*/
    }
}
