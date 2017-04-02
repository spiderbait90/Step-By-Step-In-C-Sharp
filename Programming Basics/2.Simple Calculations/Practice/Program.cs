using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double Leva = double.Parse(Console.ReadLine());
            var Msalary = days * money;
            var Ysalary = Msalary * 12 + Msalary * 2.5;
            var danuk = Ysalary * 25/100;
            var CYsalary = (Ysalary - danuk)*Leva;

            double PerDay = CYsalary / 365;


            Console.WriteLine(Math.Round(PerDay, 2));





        }
    }
}
