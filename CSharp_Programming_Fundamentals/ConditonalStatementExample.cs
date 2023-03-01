/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programming_Fundamentals
{
    class ConditonalStatementExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string myString = Console.ReadLine();
            int count = 0, index =0;

            while(index < myString.Length)
            {
                while (index < myString.Length && !char.IsWhiteSpace(myString[index]))
                    index++;

                count++;

                while (index < myString.Length && char.IsWhiteSpace(myString[index]))
                    index++;
            }
            Console.WriteLine(count);
        }
    }
}



*/