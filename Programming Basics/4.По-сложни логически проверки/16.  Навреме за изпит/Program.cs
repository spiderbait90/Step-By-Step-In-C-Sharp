using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Навреме_за_изпит
{
    class Program
    {
        static void Main(string[] args)
        {
            var h_exam = double.Parse(Console.ReadLine());
            var m_exam = double.Parse(Console.ReadLine());
            var h_arival = double.Parse(Console.ReadLine());
            var m_arival = double.Parse(Console.ReadLine());
            var MinExam = h_exam * 60 + m_exam;
            var MinArival = h_arival * 60 + m_arival;
            var timeDiff = MinExam - MinArival;
            var otherDiff = MinArival - MinExam;
            if (timeDiff >= 0 && timeDiff <= 30)
            {
                if (timeDiff == 0) Console.WriteLine("On time");
                else if (timeDiff <= 30) Console.WriteLine($"On time {timeDiff} minutes before the start");

            }
            else if (timeDiff > 30 && timeDiff < 60)
            {
                var min = timeDiff % 60;
                Console.WriteLine($"Early\n{min} minutes before the start");

            }
            else if (timeDiff > 59)
            {
                var hour = Math.Truncate(timeDiff / 60);
                var min = timeDiff % 60;
                if (min < 10) Console.WriteLine($"Early \n{hour}:0{min} hours before the start");
                else if (min>10) Console.WriteLine($"Early\n{hour}:{min} hours before the start");
            }
            else if (otherDiff > 0 && otherDiff < 60)
            {
                var min = otherDiff % 60;
                Console.WriteLine($"Late\n{min} minutes after the start");
            }
            else if (otherDiff >59)
            {
                var hour = Math.Truncate(otherDiff / 60);
                var min = otherDiff % 60;
                if (min<10) Console.WriteLine($"Late\n{hour}:0{min} hours after the start");
                else Console.WriteLine($"Late\n{hour}:{min} hours after the start");
            }


        }
    }
}
