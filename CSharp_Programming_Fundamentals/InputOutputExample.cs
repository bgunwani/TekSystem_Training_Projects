/*using System;

namespace CSharp_Programming_Fundamentals
{
    class InputOutputExample
    {
        static void Main(string[] args)
        {
            string name;
            int regNumber;
            float amount;
            double contactNumber;
            char gender;
            bool isActive;

            Console.Write("Enter Your Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Your Registration Number: ");
            regNumber = Convert.ToInt32(Console.ReadLine());
            regNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Registration Amount: ");
            amount = Convert.ToSingle(Console.ReadLine());
            amount = float.Parse(Console.ReadLine());
            Console.Write("Enter Your Contact Number: ");
            contactNumber = Convert.ToDouble(Console.ReadLine());
            contactNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter Your Gender(M/F): ");
            gender = Convert.ToChar(Console.ReadLine());
            gender = char.Parse(Console.ReadLine());
            Console.Write("Are you an active user ? (true/false): ");
            isActive = Convert.ToBoolean(Console.ReadLine());
            isActive = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your Name is " + name);
            Console.WriteLine("Your Registration Number is " + regNumber);
            Console.WriteLine("Your Registration Amount is " + amount);
            Console.WriteLine("Your Contact Number is " + contactNumber);
            Console.WriteLine("Your Gender is " + gender);
            Console.WriteLine("Your Status is " + (isActive ? "Active" : "Not Active"));

            Console.WriteLine();
            Console.WriteLine("Your Name is {0}", name);
            Console.WriteLine("Your Registration Number is {0}", regNumber);
            Console.WriteLine("Your Registration Amount is {0}", amount);
            Console.WriteLine("Your Contact Number is {0}", contactNumber);
            Console.WriteLine("Your Gender is {0}", gender);
            Console.WriteLine("Your Status is {0}", (isActive ? "Active" : "Not Active"));

            Console.WriteLine("Hello {0}, Your registration number is {1}. You have to pay {2} to complete the process.", name, regNumber, amount);

        }
    }
}
*/