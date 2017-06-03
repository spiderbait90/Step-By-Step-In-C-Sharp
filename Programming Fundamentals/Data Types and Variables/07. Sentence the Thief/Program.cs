using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var number = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                var id = long.Parse(Console.ReadLine());

                if (type == "sbyte")
                {
                    if (id <= sbyte.MaxValue && id >= sbyte.MinValue)
                    {
                        if (id > number)
                            number = id;
                    }
                }
                else if (type == "int")
                {
                    if (id <= int.MaxValue && id >= int.MinValue)
                    {
                        if (id > number)
                            number = id;
                    }
                }
                else if (type == "long")
                {
                    if (id <= long.MaxValue && id >= long.MinValue)
                    {
                        if (id > number)
                            number = id;
                    }
                }
            }
            double years;
            if (number < 0)
                years = (double)number / sbyte.MinValue;
            else
                years = (double)number / sbyte.MaxValue;
            years = Math.Ceiling(years);

            if (years>1)
                Console.WriteLine($"Prisoner with id {number} " +
                    $"is sentenced to {years} years");
            else
                Console.WriteLine($"Prisoner with id {number} " +
                    $"is sentenced to {years} year");
        }
    }
}
