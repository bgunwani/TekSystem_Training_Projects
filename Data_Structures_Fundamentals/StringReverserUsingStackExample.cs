using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Fundamentals
{
    class StringReverserUsingStackExample
    {
        public static string reverse(string input)
        {
            string reverse = "";
            Stack<char> stack = new Stack<char>();

            foreach (var ch in input.ToCharArray())
                stack.Push(ch);

            while (!(stack.Count == 0))
                reverse += stack.Pop();

            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(reverse("abcd"));
        }
    }
}
