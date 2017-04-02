using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Сумиране_на_секунди
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());

            var alltime = time1 + time2 + time3;
            var mins = alltime / 60;
            var sec = alltime % 60;
            if(sec<10)  Console.WriteLine("{0}:0{1}", mins, sec);            
            else   Console.WriteLine("{0}:{1}", mins, sec);           

        }
    }
}
