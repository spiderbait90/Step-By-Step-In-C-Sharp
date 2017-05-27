using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var total = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "cheese":total += 500;break;
                    case "tomato sauce":total += 150;break;
                    case "salami": total += 600; break;
                    case "pepper": total += 50; break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {total}");
        }
    }
}
