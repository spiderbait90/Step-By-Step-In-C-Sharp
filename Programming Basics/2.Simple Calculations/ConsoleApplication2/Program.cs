﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = Double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.WriteLine("Centimeters = {0} ", centimeters);
            
        }
    }
}
