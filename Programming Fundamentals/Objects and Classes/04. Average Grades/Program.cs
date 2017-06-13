using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Avarege
        {
            get
            {
                return Grades.Average();
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var student = new Student();
                student.Name = input[0];
                student.Grades = new List<double>();
                student.Grades.AddRange
                    (input.Skip(1).Select(double.Parse).ToList());
                list.Add(student);
            }

            foreach (var item in list.Where(x => x.Avarege >= 5.00)
                .OrderBy(x=>x.Name).ThenByDescending(x=>x.Avarege))
            {
                Console.WriteLine($"{item.Name} -> {item.Avarege:f2}");
            }
        }
    }
}
