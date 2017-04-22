using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var nameAndGrade = Console.ReadLine().Split();
                var name = nameAndGrade[0];var grade = double.Parse(nameAndGrade[1]);

                if (!data.ContainsKey(name))
                {
                    data[name] = new List<double>();
                }
                data[name].Add(grade);
            }

            foreach (var nameAndGrade in data)
            {
                Console.Write($"{nameAndGrade.Key} -> ");
                foreach (var grade in nameAndGrade.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {nameAndGrade.Value.Average():f2})");    
            }
        }
    }
}
