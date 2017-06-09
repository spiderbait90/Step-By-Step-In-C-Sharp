using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var numberPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var specialNum = numberPower[0];
            var count = numberPower[1];
            while (numbers.Contains(specialNum))
            {
                var index = numbers.IndexOf(specialNum)-count;
                var total = (count * 2) + 1;
                if (index < 0)
                    index = 0;

                for (int i = 0; i <total; i++)
                {
                    if (index > numbers.Count - 1)
                        break;
                    numbers.RemoveAt(index);
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
