using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var cubeSide = double.Parse(Console.ReadLine());
            var str = Console.ReadLine();

            Console.WriteLine($"{Cube(str, cubeSide):f2}");           
                        
        }

        static double Cube(string str,double side)
        {
            
            var result = 0.0;
            if (str == "face")
            {
                result = Math.Sqrt(2 * Math.Pow(side, 2));
            }
            else if (str=="space")
            {
                result = Math.Sqrt(3 * Math.Pow(side, 2));
            }
            else if (str == "volume")
            {
                result = Math.Pow(side, 3);
            }
            else if (str == "area")
            {
                result = 6 * Math.Pow(side, 2);
            }
            return result;
        }
    }
}
