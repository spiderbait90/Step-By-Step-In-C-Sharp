using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Water_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalWater = double.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split()
                .Select(double.Parse).ToList();
            var capacity = int.Parse(Console.ReadLine());
            var bottlesLeft = new List<int>();
            double waterNeeded = 0;
            if (totalWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Count; i++)
                {
                    var neededWater = capacity - bottles[i];
                    if (totalWater >= neededWater && totalWater > 0)
                    {
                        bottles[i] = capacity;
                        totalWater -= neededWater;
                    }
                    else if (totalWater > 0)
                    {
                        bottles[i] += totalWater;
                        totalWater = 0;
                        bottlesLeft.Add(i);
                        waterNeeded += capacity - bottles[i];
                    }
                    else
                    {
                        bottlesLeft.Add(i);
                        waterNeeded += neededWater;
                    }
                }
            }
            else
            {
                for (int i = bottles.Count - 1; i >= 0; i--)
                {
                    var neededWater = capacity - bottles[i];
                    if (totalWater >= neededWater&&totalWater>0)
                    {
                        bottles[i] = capacity;
                        totalWater -= neededWater;
                    }
                    else if (totalWater>0)
                    {
                        
                        bottles[i] += totalWater;
                        totalWater = 0;
                        bottlesLeft.Add(i);
                        waterNeeded += capacity - bottles[i];
                    }
                    else
                    {
                        bottlesLeft.Add(i);
                        waterNeeded += neededWater;
                    }
                }
            }

            if (totalWater==0)
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {bottlesLeft.Count}");
                Console.WriteLine($"With indexes: {string.Join(", ",bottlesLeft)}");
                Console.WriteLine($"We need {waterNeeded} more liters!");
            }
            else if (totalWater>0)
            {
                Console.WriteLine($"Enough water!");
                Console.WriteLine($"Water left: {totalWater}l.");
            }
        }
    }
}
