using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    class Program
    {
        static void Main(string[] args)
        {
            var Students = int.Parse(Console.ReadLine());
            double five = 0; double four = 0; double three = 0; double two = 0;
            var avarege = 0.0;
            for (int i = 1; i <= Students; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00) five += 1;
                else if (grade >= 4.00) four += 1;
                else if (grade >= 3.00) three += 1;
                else if (grade >= 2.00) two += 1;
                avarege += grade;
            }
            five = (five/Students)*100;
            four = (four/Students) * 100;
            three = (three/Students) * 100;
            two = (two/Students) * 100;
            avarege /= Students;

            Console.WriteLine($"Top students: {five:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: { four:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {three:f2}%");
            Console.WriteLine($"Fail: { two:f2}%");
            Console.WriteLine($"Average: {avarege:f2}");

        }
    }
}
