using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in answer)
            {
                Console.WriteLine(name);
            }

        }
    }
}
