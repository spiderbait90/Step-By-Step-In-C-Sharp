using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Tour
{
    class Truck_Tour
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var road = new Queue<long>();
            for (int i = 0; i < n; i++)
            {
                long[] input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                road.Enqueue(input[0]);
                road.Enqueue(input[1]);
            }
            long index = 0;
            long lenght = 0;
            long totalPetrol = 0;
            var allValidIndexes = new List<long>();
            while (index < road.Count / 2)
            {
                var petrol = road.Dequeue();
                var distance = road.Dequeue();
                totalPetrol += petrol;

                if (totalPetrol < distance || lenght == 4)
                {
                    index++;
                    lenght = 0;
                    totalPetrol = 0;
                }
                else
                {
                    lenght++;
                    totalPetrol -= distance;
                    if (lenght == 4)
                        allValidIndexes.Add(index);
                }
                road.Enqueue(petrol);
                road.Enqueue(distance);
            }
            Console.WriteLine(allValidIndexes.Min());
        }
    }
}