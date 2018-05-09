using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                var firstN = int.Parse(stack.Pop());
                var op = stack.Pop();
                var secondN = int.Parse(stack.Pop());

                stack.Push(op == "+" ? (firstN + secondN).ToString() : (firstN - secondN).ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
