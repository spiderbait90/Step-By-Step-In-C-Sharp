using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            var check = true;

            foreach (var c in input)
            {
                if (c == '[')
                {
                    stack.Push(c);
                }
                else if (c == '{')
                {
                    stack.Push(c);
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }

                else
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == '[' && c == ']')
                        {
                            stack.Pop();
                        }
                        else if (stack.Peek() == '{' && c == '}')
                        {
                            stack.Pop();
                        }
                        else if (stack.Peek() == '(' && c == ')')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            check = false;
                        }
                    }
                    else
                    {
                        check = false;
                    }
                }
            }

            Console.WriteLine(check ? "YES" : "NO");
        }
    }
}
