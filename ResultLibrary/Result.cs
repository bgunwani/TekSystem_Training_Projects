using System;
using SportsLibrary;

namespace ResultLibrary
{
    public class Result : Sports
    {
        private float totalMarks;
        private float averageMarks;
        public void calculateResult()
        {
            this.totalMarks = this.objectiveMarks + this.subjectiveMarks + this.score;
            this.averageMarks = this.totalMarks / 3;
            Console.WriteLine("Total Marks: " + this.totalMarks);
            Console.WriteLine("Average Marks: " + this.averageMarks);
            if (this.objectiveMarks > 70 && this.subjectiveMarks > 70 && this.averageMarks > 75)
                Console.WriteLine("Congratualtions!! You are shortlisted.");
            else
                Console.WriteLine("OOPS!! Better Luck Next Time.");
        }
    }

}
