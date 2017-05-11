using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var bees = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < bees.Length; i++)
            {
                var horrnetSum = hornets.Sum();
                if (hornets.Count == 0)
                    break;
                if (horrnetSum < bees[i])
                {
                    bees[i] -= hornets.Sum();
                    hornets.RemoveAt(0);
                }
                else if (horrnetSum == bees[i])
                {
                    bees[i] = 0;
                    hornets.RemoveAt(0);
                    
                }
                else if (horrnetSum > bees[i])
                {
                    bees[i] = 0;                    
                }
            }
            var bee = new List<long>();
            foreach (var item in bees)
            {
                if (item != 0)
                    bee.Add(item);
            }

            if (bee.Count > 0)
                Console.WriteLine(string.Join(" ", bee));
            else
                Console.WriteLine(string.Join(" ", hornets));
        }
    }
}
