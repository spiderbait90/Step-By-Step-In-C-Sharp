using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var str = new StringBuilder();
            var lastChange = new Stack<string>();
            var commands = new Stack<string>();
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                if (input[0] == "1")
                {
                    str.Append(input[1]);
                    lastChange.Push(input[1]);
                    commands.Push("1");
                }
                else if (input[0] == "2")
                {
                    var count = int.Parse(input[1]);
                    var removed = str.ToString().Substring(str.Length - count);
                    lastChange.Push(removed);
                    str.Remove(str.Length - count, count);                    
                    commands.Push("2");
                }
                else if (input[0] == "3")
                {
                    var index = int.Parse(input[1]);
                    Console.WriteLine(str[index - 1]);
                }
                else if (input[0] == "4")
                {
                    if (commands.Peek() == "1")
                    {
                        str.Remove(str.Length - lastChange.Peek().Length, lastChange.Pop().Length);
                        commands.Pop();
                    }
                    else if (commands.Peek() == "2")
                    {
                        str.Append(lastChange.Pop());
                        commands.Pop();
                    }
                }
            }
        }
    }
}
