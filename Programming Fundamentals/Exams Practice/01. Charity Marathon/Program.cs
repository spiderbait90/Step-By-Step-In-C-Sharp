using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long avaregeLapsPerRunner = int.Parse(Console.ReadLine());
            long lenghtTrack = long.Parse(Console.ReadLine());
            long capacityTrack = int.Parse(Console.ReadLine());
            double donatedMoneyPerKM = double.Parse(Console.ReadLine());

            var runnersLeft = days * capacityTrack;
            long totalRunnurs = 0;
            if (runnersLeft > runners)
                totalRunnurs = runners;
            else
                totalRunnurs = runnersLeft;

            double totalMeters = (double)totalRunnurs * (double)avaregeLapsPerRunner * (double)lenghtTrack;
            double totalKM = totalMeters / 1000;
            double raisedMoney = donatedMoneyPerKM * totalKM;

            Console.WriteLine($"Money raised: {raisedMoney:f2}");
        }
    }
}
