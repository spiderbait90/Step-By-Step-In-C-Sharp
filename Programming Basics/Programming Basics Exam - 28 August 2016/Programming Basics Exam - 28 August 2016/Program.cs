using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_Exam___28_August_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var WorkdaysPerMonth = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var USD = double.Parse(Console.ReadLine());

            var salary = WorkdaysPerMonth * moneyPerDay;
            var yearsalary = salary * 12 + salary * 2.50;
            var cleanmoney = yearsalary - yearsalary * 0.25;
            cleanmoney = cleanmoney * USD;

            var earnperday = cleanmoney / 365;
            Console.WriteLine($"{earnperday:f2}");

        }
    }
}
