using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var days = 0;

            while (true)
            {
                var check = true;
                days++;

                int last = arr[0];
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (last < arr[i + 1])
                    {
                        last = arr[i + 1];
                        arr.RemoveAt(i + 1);
                        check = false;
                        i--;
                    }
                    else
                    {
                        last = arr[i + 1];
                    }
                }

                if (check)
                    break;
            }

            Console.WriteLine(days - 1);
        }
    }
}
