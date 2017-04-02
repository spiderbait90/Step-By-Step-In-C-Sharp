using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());
            var a = 0.0; var b = 0.0; var c = 0.0; var d = 0.0;

            var totalgrade = 0.0;
            for (int i = 0; i < students; i++)             
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade >= 2.00 && grade <= 2.99) d++;
                else if (grade >= 3.00 && grade <= 3.99) c++;
                else if (grade >= 4.00 && grade <= 4.99) b++;
                else if (grade >= 5.00) a++;
                totalgrade += grade;
            }
            var aPerc = (a * 100 / students);
            var bPerc = (b * 100 / students);
            var cPerc = (c * 100 / students);
            var dPerc = (d * 100 / students);
            var result = totalgrade / students;
            Console.WriteLine($"Top students: {aPerc:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {bPerc:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {cPerc:f2}%");
            Console.WriteLine($"Fail: {dPerc:f2}%");
            Console.WriteLine($"Average: {result:f2}");

        }
    }
}
