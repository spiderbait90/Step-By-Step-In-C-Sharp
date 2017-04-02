using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            var RestDays = int.Parse(Console.ReadLine());
            var rest = RestDays * 127;
            var work = 365 - RestDays;
            work = work * 63;
            var minutes = work + rest;
            if (minutes <=30000)
            {
                var result = 30000 - minutes;
                var hours = result / 60;
                var min = result % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, min);
                
            }
            else if(minutes>30000)
            {
                var result = minutes - 30000;
                var hours = result / 60;
                var min = result % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, min);
            }

        }
    }
}
