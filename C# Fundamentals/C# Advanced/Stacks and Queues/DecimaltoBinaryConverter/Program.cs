using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimaltoBinaryConverter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            while (input > 0)
            {
                stack.Push(input % 2);
                input /= 2;
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop());
                }
                Console.WriteLine();
            }
            
        }
    }
}
