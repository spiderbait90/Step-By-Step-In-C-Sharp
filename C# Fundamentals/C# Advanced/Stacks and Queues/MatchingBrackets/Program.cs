using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    stack.Push(i);

                else if (input[i] == ')')
                {
                    var start = stack.Pop();

                    Console.WriteLine(input.Substring(start, i - start + 1));
                }
            }
        }
    }
}
