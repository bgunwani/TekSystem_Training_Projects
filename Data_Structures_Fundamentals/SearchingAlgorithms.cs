using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Fundamentals
{
    class Search
    {
        public int linearSearch(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == target)
                    return i;
            return -1;
        }

        public int iterativeBinarySearch(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;
            while(left<= right)
            {
                var middle = (left + right) / 2;
                if (numbers[middle] == target)
                    return middle;
                if (target < numbers[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }
        public int recurssiveBinarySearch(int[] numbers, int target, int left, int right)
        {
            if (right < left)
                return -1;

            int middle = (left + right) / 2;
            if (numbers[middle] == target)
                return middle;
            if (target < numbers[middle])
                return recurssiveBinarySearch(numbers, target, left, middle - 1);
            else
                return recurssiveBinarySearch(numbers, target, middle + 1, right);
        }

    }
    class SearchingAlgorithms
    {
        /*static void Main(string[] args)
        {

            int[] numbers = { 7, 1, 3, 6, 5 };
            Search search = new Search();
            var index = search.linearSearch(numbers, 6);
            Console.WriteLine(index >=0 ? "Element Found" : "Element Not Found.");

            Array.Sort(numbers);
            index = search.iterativeBinarySearch(numbers, 60);
            Console.WriteLine(index >= 0 ? "Element Found" : "Element Not Found.");

            index = search.recurssiveBinarySearch(numbers, 6,0, numbers.Length-1);
            Console.WriteLine(index >= 0 ? "Element Found" : "Element Not Found.");

        }*/
    }
}

/* Linear Search
 *          Best Case - O(1)
 *          Wrost Case - O(n)
 *  Binary Search
 *          Best/Worst Case - O(log n)
 */
