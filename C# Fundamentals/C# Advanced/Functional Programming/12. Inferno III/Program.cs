using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Forge")
                    break;



            }
        }
    }
}
