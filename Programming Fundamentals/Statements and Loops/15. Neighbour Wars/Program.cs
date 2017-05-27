using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;
            var rounds = 1;
            while (peshoHealth > 0 && goshoHealth > 0)
            {
                if (rounds % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth < 1)
                        break;
                    Console.WriteLine($"Gosho used" +
                        $" Thunderous fist and reduced " +
                        $"Pesho to" +
                        $" {peshoHealth} health.");
                }
                else if (rounds % 2 != 0)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth < 1)
                        break;
                    Console.WriteLine($"Pesho used" +
                        $" Roundhouse kick and reduced " +
                        $"Gosho to" +
                        $" {goshoHealth} health.");
                }
                if (rounds % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
                rounds++;
            }

            if (peshoHealth>0)
                Console.WriteLine($"Pesho won in {rounds}th round.");
            else
                Console.WriteLine($"Gosho won in {rounds}th round.");

        }
    }
}
