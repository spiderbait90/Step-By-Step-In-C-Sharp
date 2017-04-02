using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Обръщение_според_възраст_и_пол
{
    class Program
    {
        static void Main(string[] args)
        {
            var Age = double.Parse(Console.ReadLine());
            var Gender = Console.ReadLine();
            if (Age < 16)
            {
                if (Gender == "m") Console.WriteLine("Master");
                else if (Gender == "f") Console.WriteLine("Miss");
            }           
            else
            {
                if (Gender == "m") Console.WriteLine("Mr.");
                else if (Gender == "f") Console.WriteLine("Ms.");
            }
        }
    }
}
