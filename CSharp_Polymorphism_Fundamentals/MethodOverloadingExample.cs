/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Polymorphism_Fundamentals
{
    class Calculation
    {
        public int addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public double addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public int addition(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
                result += numbers[i];
            return result;
        }
        public double addition(double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
                result += numbers[i];
            return result;
        }
    }

    class MethodOverloadingExample
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30, 40, 50 };
            double[] doubleArray = { 10.5, 12.5, 35.4, 36.2, 13.6 };

            Calculation calculation = new Calculation();

            Console.WriteLine(calculation.addition(100, 200));  // 8 Bytes
            Console.WriteLine(calculation.addition(123.45d, 321.54d)); // 16 Bytes
            Console.WriteLine(calculation.addition(intArray)); // 20 Bytes
            Console.WriteLine(calculation.addition(doubleArray));  // 40 Bytes

        }
    }
}
*/