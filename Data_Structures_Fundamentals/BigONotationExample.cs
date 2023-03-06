using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Fundamentals
{
    class BigONotation
    {
        public void constantNotation(int[] numbers)
        {
            // O(1) + O(1)
            // = O(2)
            // = O(1) (Constant Notation)

            // O(1) - Constant
            Console.WriteLine(numbers[0]);
            // O(1) - Constant
            Console.WriteLine(numbers[0]);
        }
        public void linearNotation(int[] numbers, string[] names)
        {
            // O(1) + O(n) + O(1) + O(n) + O(m)
            // O(2) + O(n) + O(n) + O(m)
            // O(n) - Linear Notation

            Console.WriteLine();     // O(1)
            foreach (var number in numbers) // O(n)
                Console.WriteLine(number);
            Console.WriteLine();    // O(1)
            foreach (var number in numbers) // O(n)
                Console.WriteLine(number);
            foreach (var name in names)  // O(m)
                Console.WriteLine(name);    
        }
        public void quadraticNotation(int[] numbers)
        {
            // O(n) * O(n) + O(n)
            // = O(n^2) + O(n)
            // = O(n^2) - Quadratic Notation

            foreach (var number in numbers) // O(n)
                Console.WriteLine(number);

            foreach (var first in numbers)  // O(n)
                foreach (var second in numbers) // O(n)
                    Console.WriteLine(first + ", " + second);
        }
    }
    class BigONotationExample
    {
      /*  static void Main(string[] args)
        {
            BigONotation example = new BigONotation();

            int[] numbers = { 10, 20, 30, 40, 50 };
            string[] names = { "Karthik", "Shivam", "Rishi" };
            
            example.constantNotation(numbers);

            Console.WriteLine("********************************");

            example.linearNotation(numbers, names);

            Console.WriteLine("********************************");

            example.quadraticNotation(numbers);

        }*/
    }
}
