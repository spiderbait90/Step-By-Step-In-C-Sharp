using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var recorces = new Dictionary<string, int>();
            var previous = "";
            for (int i = 1; ; i++)
            {
                var input = Console.ReadLine();

                if (input == "stop")
                    break;

                else if (i % 2 != 0)
                {
                    if (!recorces.ContainsKey(input))
                        recorces[input] = new int();
                    previous = input;
                }
                else if (i % 2 == 0)
                {
                    recorces[previous] += int.Parse(input);
                }
            }

            foreach (var item in recorces)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
