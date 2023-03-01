using ResultLibrary;
using System;

namespace CSharp_Inheritance_Polymorphism_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Result info = new Result();
            info.acceptDetails();
            info.displayDetails();
            info.calculateResult();

        }
    }
}
