using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());
            var years = centuries * 100;
            var days = (ulong)(years * 365.2422);
            decimal hours = days * 24;
            decimal min = hours * 60;
            decimal sec = min * 60;
            decimal milSec = sec * 1000;
            decimal micSec = milSec * 1000;
            decimal nanoSec = micSec * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {min} minutes = {sec} seconds = {milSec} milliseconds = {micSec} microseconds = {nanoSec} nanoseconds");

        }
    }
}
