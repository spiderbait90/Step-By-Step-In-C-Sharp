using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var health = long.Parse(Console.ReadLine());
            var initialHealth = health;
            var viruses = new List<string>();
            while (true)
            {
                var virus = Console.ReadLine();
                if (virus == "end")
                    break;
               
                var virusStrenght = 0;
                foreach (var letter in virus)
                {
                    virusStrenght += letter;
                }
                virusStrenght /= 3;

                var seconds = virusStrenght * virus.Length;
                if (viruses.Contains(virus))
                    seconds /= 3;
                var min = seconds / 60;
                var sec = seconds % 60;
                
                Console.WriteLine($"Virus {virus}: {virusStrenght} " +
                    $"=> {seconds} seconds");

                if (seconds > health)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                health -= seconds;
                Console.WriteLine($"{virus} defeated in {min}m {sec}s.");
                Console.WriteLine($"Remaining health: {health}");
                health += (long)(health * 0.20);
                if (health > initialHealth)
                    health = initialHealth;

                viruses.Add(virus);
            }

            Console.WriteLine($"Final Health: {health}");
        }
    }
}
