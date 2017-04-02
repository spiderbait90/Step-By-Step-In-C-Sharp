using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Конвертор_за_мерни_единици
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = double.Parse(Console.ReadLine());
            var sourceMetric = Console.ReadLine().ToLower();
            var destMetric = Console.ReadLine().ToLower();
            if (sourceMetric == "km") size /= 0.001; // same as others
            else if (sourceMetric == "ft") size = size / 3.2808399;
            else if (sourceMetric == "yd") size = size / 1.0936133;
            else if (sourceMetric == "in") size = size / 39.3700787; 
            else if (sourceMetric == "mi") size = size / 0.000621371192;
            else if (sourceMetric == "cm") size = size / 100;            
            else if (sourceMetric=="mm") size = size / 1000;                      
                  
            if (destMetric == "ft") size = size * 3.2808399; 
            else if(destMetric=="yd") size = size * 1.0936133; 
            else if (destMetric == "mm") size = size * 1000; 
            else if (destMetric == "cm") size = size * 100; 
            else if (destMetric == "mi") size = size * 0.000621371192;
            else if (destMetric == "in") size = size * 39.3700787;
            else if (destMetric == "km") size = size * 0.001; 
            
            Console.WriteLine($"{size} {destMetric}");
        }
    }
}
