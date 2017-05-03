using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Serialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var output = new StringBuilder();

            foreach (var letter in input.Distinct())
            {
                var index = 0;
                output.Append(letter + ":");

                while (true)
                {
                    index = input.IndexOf(letter, index);
                    if (index < 0)
                    {
                        break;
                    }                        
                    output.Append(index+"/");                    
                    index++;
                }
                output.Remove(output.Length-1, 1);
                output.AppendLine();
            }
            Console.WriteLine(output.ToString().TrimEnd());
        }
    }
}
