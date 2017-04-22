using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ').ToList();
            var energy = int.Parse(Console.ReadLine());

            for (int i = 0; i < str.Count; i++)
            {
                var splited = str[i].Split('|');
                if (splited[0] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else if (splited[0] == "Left")
                {
                    var count = int.Parse(splited[1]);
                    energy -= int.Parse(splited[1]);
                    while (count > 0)
                    {
                        i--;
                        count--;
                        if (i == -1)
                        {
                            i = str.Count - 1;
                        }
                    }
                    i -= 1;
                }
                else if (splited[0] == "Right")
                {
                    var count = int.Parse(splited[1]);
                    energy -= int.Parse(splited[1]);
                    while (count > 0)
                    {
                        i++;
                        count--;
                        if (i == str.Count)
                        {
                            i = 0;
                        }
                    }
                    i-=1;
                }
                else if (splited[0] == "Bomb")
                {
                    energy -= int.Parse(splited[1]);
                    str.RemoveAt(i);
                    i = -1;
                }
                if (energy <= 0)
                {
                    if (splited[0] == "Left" || splited[0] == "Right")
                        Console.WriteLine("You are tired. You can't continue the mission.");
                    else if (splited[0] == "Bomb")
                        Console.WriteLine("You are dead due to bomb explosion!");
                    return;
                }
                if (str[str.Count-1]=="RabbitHole")
                {
                    str.Add($"Bomb|{energy}");
                }
                else if (str[str.Count - 1] != "RabbitHole")
                {
                    str.RemoveAt(str.Count - 1);
                    str.Add($"Bomb|{energy}");
                }

            }
        }
    }
}
