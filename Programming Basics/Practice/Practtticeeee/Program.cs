using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practtticeeee
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var num = 0;var num2 = 0;
            for (int row = 0; row < n; row++)
            {

                for (int cow = 0; cow < n; cow++)
                {
                    num = row + cow + 1;
                    num2 = 2 * n - num;
                    if (num <= n)
                    {

                        Console.Write(num + " ");
                    }
                    
                    else
                    {

                        Console.Write(num2 + " ");

                    }

                }
                Console.WriteLine();
            }    
            
         }
            
        }
    }

