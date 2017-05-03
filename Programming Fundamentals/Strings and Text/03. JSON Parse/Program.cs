using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Parse
{
    public class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<int> Grades { get; set; }
        }
        public static void Main(string[] args)
        {

            var splitText = Console.ReadLine()
                .Split(new[] { '}',']' },
                StringSplitOptions.RemoveEmptyEntries);
            var collection = new Dictionary<string, List<Student>>();

            foreach (var line in splitText)
            {
                var split = line.Split
                    (new[] { ' ', '[', '{', ':', '"', ',', ']', '}' },
                    StringSplitOptions.RemoveEmptyEntries);
                var name = split[1];
                var age = int.Parse(split[3]);
                var grades = new List<int>();
                if (split.Length > 5)
                {
                    grades = split.Skip(5).Select(int.Parse).ToList();
                }                
                var student = new Student();                
                student.Name = name;
                student.Age = age;
                student.Grades = grades;
                if (!collection.ContainsKey(name))
                {
                    collection[name] = new List<Student>();
                    collection[name].Add(student);
                }                
            }
            var str = new StringBuilder();
            foreach (var students in collection.Values)
            {
                foreach (var student in students)
                {
                    str = str.Append($"{student.Name} : {student.Age} -> ");
                    if (student.Grades.ToArray().Length == 0)
                        str = str.AppendLine("None");
                    else
                        str = str.AppendLine(string.Join(", ", student.Grades));
                }                
            }
            Console.Write(str.ToString());
        }
    }
}
