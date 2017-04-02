using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Цена_за_транспорт
{
    class Program
    {
        static void Main(string[] args)
        {
            var Price = double.Parse(Console.ReadLine());
            var DorN = Console.ReadLine();
            if (Price <= 19)
            {
                if (DorN == "day")
                {
                    var taxi = 0.70 + Price * 0.79;
                    Console.WriteLine(taxi);
                }
                else if (DorN == "night")
                {
                    var taxi = 0.70 + Price * 0.90;
                    Console.WriteLine(taxi);
                }
            }
            else if(Price<=99)
            {
                var bus = Price * 0.09;
                Console.WriteLine(bus);
            }
            else
            {
                var train = Price * 0.06;
                Console.WriteLine(train);
            }
            }
                 
            }
        }
    

