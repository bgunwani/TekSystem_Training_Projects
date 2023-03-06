/*using System;

namespace Data_Structures_Fundamentals
{
    class WorkingWithArrays
    {
        static void Main(string[] args)
        {
            // Declaration of Array
            int[] intArray = new int[5];

            // Assignment in Array
            intArray[0] = 10;
            intArray[1] = 20;
            intArray[1] = 30;
            intArray[1] = 40;
            intArray[1] = 50;

            // Initialization of Array (Declaration plus Assignment)
            int[] integerArray = new int[] { 10, 20, 30, 40, 50 };

            // Iterate the Array Elements using For Loop
            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);

            // Iterate the Array Elements using For Loop
            foreach (int value in intArray)
                Console.WriteLine(value);

            // Types of Arrays: Single Dimensional, Multi Dimensional, Jagged Array and Mixed Array

            int[] singleDimensionalArray = new int[] { 10, 20, 30, 40, 50 };
            int[] singleArray = new int[5];
            singleArray[0] = 10;
            singleArray[1] = 20;
            singleArray[1] = 30;
            singleArray[1] = 40;
            singleArray[1] = 50;

            int[,] multiDimensionalArray = new int[,] { { 10, 20, 30 }, { 40, 50, 60 } };
            int[,] multiArray = new int[2, 3];
            multiArray[0, 0] = 10;
            multiArray[0, 1] = 20;
            multiArray[0, 2] = 30;
            multiArray[1, 0] = 40;
            multiArray[1, 1] = 50;
            multiArray[1, 2] = 60;

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2] { 100, 200 };
            jaggedArray[1] = new int[5] {10,20,30,40,50 };
            jaggedArray[2] = new int[3] { 110, 220, 330 };
            Console.WriteLine(jaggedArray[0][0]);
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

           
            Console.WriteLine("**************************************");

            // The Array Class
            Array myArray = Array.CreateInstance(typeof(string), 3);
            myArray.SetValue("Bhawna Gunwani", 0);
            myArray.SetValue("Sarah Bowling", 1);
            myArray.SetValue("Gautam Bhalla", 2);
            foreach (var item in myArray)
                Console.WriteLine(item);
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine(myArray.GetValue(i));

            Console.WriteLine("**************************************");

            Array.Sort(myArray);
            foreach (var item in myArray)
                Console.WriteLine(item);

            Console.WriteLine("**************************************");

            Array.Reverse(myArray);
            foreach (var item in myArray)
                Console.WriteLine(item);

            Console.WriteLine("**************************************");

            Array.Clear(myArray, 0,1);
            foreach (var item in myArray)
                Console.WriteLine(item);

            Console.WriteLine("**************************************");

            Console.WriteLine(myArray.GetLength(0));
            Console.WriteLine(myArray.GetLowerBound(0));
            Console.WriteLine(myArray.GetUpperBound(0));
        }
    }
}
*/