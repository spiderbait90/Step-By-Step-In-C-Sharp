using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = new string(Console.ReadLine().Reverse().ToArray());
            var stack = new Stack<string>();

            stack.Push(input);

            Console.WriteLine(stack.Pop());
        }
    }
}
