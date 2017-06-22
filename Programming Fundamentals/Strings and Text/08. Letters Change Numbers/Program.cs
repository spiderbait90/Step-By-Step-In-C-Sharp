using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ','\t' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            decimal sum = 0;

            foreach (var word in input)
            {
                var first = word.First();
                var last = word.Last();
                var extractN = word.Where(x => char.IsDigit(x))
                    .ToArray();
                var number = decimal.Parse(new string(extractN));

                if (char.IsUpper(first))
                    number /= (first - 64);
                else if (char.IsLower(first))
                    number *= (first - 96);

                if (char.IsUpper(last))
                    number -= (last - 64);
                else if (char.IsLower(last))
                    number += (last - 96);

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
