using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var beatsPerMin = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());

            var bars = Math.Round(numberOfBeats / 4, 1);
            var secondsPerBeat = 60 / beatsPerMin;
            var seconds = (numberOfBeats * secondsPerBeat) % 60;
            var min = (numberOfBeats * secondsPerBeat) / 60;

            Console.WriteLine($"{bars} bars - {(int)min}m {(int)seconds}s");
        }
    }
}
