using MarksLibrary;
using System;


namespace SportsLibrary
{
    public class Sports : Marks
    {
        protected float score;
        public new void acceptDetails()
        {
            base.acceptDetails();
            Console.Write("Enter Sports Score: ");
            this.score = float.Parse(Console.ReadLine());
        }
        public new void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Sports Score: {0}", this.score);
        }
    }
}
