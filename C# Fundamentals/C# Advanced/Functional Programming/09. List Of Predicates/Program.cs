using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var reasult = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                var check = true;

                foreach (var num in numbers)
                {
                    if (i % num != 0)
                        check = false;
                }

                if(check)
                    reasult.Add(i);
            }

            Console.WriteLine(string.Join(" ",reasult));
        }
    }
}
