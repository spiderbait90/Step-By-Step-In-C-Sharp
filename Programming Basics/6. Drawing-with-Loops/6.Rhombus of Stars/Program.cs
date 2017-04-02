using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int top = 1; top <= n; top++)
            {

                for (int i = 1; i <= n - top; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 1; i < top; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int bot = 1; bot <= n - 1; bot++)
            {
                for (int i = 1; i <= bot; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 1; i < n - bot; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        }
    }

