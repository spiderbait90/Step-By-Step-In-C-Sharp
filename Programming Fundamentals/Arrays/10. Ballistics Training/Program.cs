using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var positionOfPlane = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var changeFireCord = Console.ReadLine()
                .Split()
                .ToArray();
            int[] fireCord = new int[2];
            fireCord[0] = 0;
            fireCord[1] = 0;

            for (int i = 0; i < changeFireCord.Length; i++)
            {
                if (changeFireCord[i] == "up")
                    fireCord[1] += int.Parse(changeFireCord[i + 1]);

                else if (changeFireCord[i] == "down")
                    fireCord[1] -= int.Parse(changeFireCord[i + 1]);

                else if (changeFireCord[i] == "left")
                    fireCord[0] -= int.Parse(changeFireCord[i + 1]);

                else if (changeFireCord[i] == "right")
                    fireCord[0] += int.Parse(changeFireCord[i + 1]);
            }
            Console.WriteLine($"firing at [{fireCord[0]}," +
                $" {fireCord[1]}]");
            var button = true;
            for (int i = 0; i < fireCord.Length; i++)
            {
                if (fireCord[i] != positionOfPlane[i])
                    button = false;
            }

            if (button)
                Console.WriteLine("got 'em!");
            else
                Console.WriteLine("better luck next time...");
            
        }
    }
}
