using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            var leapOrNot = Console.ReadLine().ToLower();
            var praznici = double.Parse(Console.ReadLine());
            var home = double.Parse(Console.ReadLine());

            var games = 48 - home;
            games = games * 3 / 4;
            var praznik = praznici * 2 / 3;
            games = games + praznik + home;
            if (leapOrNot=="leap")
            {
                var leap = games * 0.15;
                games = leap + games;
                Console.WriteLine(Math.Floor(games));
            }
            else Console.WriteLine(Math.Floor(games));

        }
    }
}
