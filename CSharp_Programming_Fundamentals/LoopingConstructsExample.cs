using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programming_Fundamentals
{
    class LoopingConstructsExample
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int i = 0;
            // Iterating Array Elements using for Loop:
            for (i=0; i < numbers.Length; i++)
            {
                if (i%2 == 0)
                    continue;
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("----------------------");

            // Iterating Array Elements using While Loop:
            i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }

            Console.WriteLine("----------------------");

            // Iterate Array Elements using foreach loop
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }
    }
}
