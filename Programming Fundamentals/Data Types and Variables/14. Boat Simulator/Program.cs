using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var boat1 = char.Parse(Console.ReadLine());
            var boat2 = char.Parse(Console.ReadLine());
            var n = sbyte.Parse(Console.ReadLine());
            var distance1 = 0;
            var distance2 = 0;
            for (int i = 1; i <= n; i++)
            {
                if (distance1 > 49)
                {
                    Console.WriteLine(boat1);
                    return;
                }
                else if (distance2>49)
                {
                    Console.WriteLine(boat2);
                    return;
                }
                var str = Console.ReadLine();

                if (str != "UPGRADE")
                {
                    if (i % 2 == 0)
                        distance2 += str.Length;
                    else if (i % 2 != 0)
                        distance1 += str.Length;
                }
                else
                {                    
                        boat2 += (char)3;
                        boat1 += (char)3;
                }
            }
            if (distance1>distance2)
                Console.WriteLine(boat1);
            else if (distance1<distance2)
                Console.WriteLine(boat2);
        }
    }
}
