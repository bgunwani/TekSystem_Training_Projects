using StudentLibrary;
using System;

namespace MarksLibrary
{
    public class Marks : Student
    {
        protected float objectiveMarks;
        protected float subjectiveMarks;
        public new void acceptDetails()
        {
            base.acceptDetails();
            Console.Write("Enter Objective Marks: ");
            this.objectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks: ");
            this.subjectiveMarks = float.Parse(Console.ReadLine());
        }
        public new void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Objective Marks: {0}", this.objectiveMarks);
            Console.WriteLine("Subjective Marks: {0}", this.subjectiveMarks);
        }
    }
}
