using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<int>();
            int lastBangedDigit = 0;
            while (true)
            {
                if (input == "bang")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastBangedDigit}");
                        return;
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] < list.Average())
                        {
                            Console.WriteLine($"shot {list[i]}");
                            lastBangedDigit = list[i];
                            list.RemoveAt(i);
                            for (int a = 0; a < list.Count; a++)
                            {
                                list[a]--;
                            }
                            break;
                        }
                        else if (list.Count == 1)
                        {
                            Console.WriteLine($"shot {list[0]}");
                            lastBangedDigit = list[0];
                            list.RemoveAt(0);
                        }
                    }
                }
                else if (input=="stop")
                {
                    if (list.Count==0)
                    {
                        Console.WriteLine($"you shot them all. last one was {lastBangedDigit}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"survivors: {string.Join(" ",list)}");
                        return;
                    }
                }
                else
                {
                    list.Insert(0, int.Parse(input));
                }
                input = Console.ReadLine();
            }
        }
    }
}
