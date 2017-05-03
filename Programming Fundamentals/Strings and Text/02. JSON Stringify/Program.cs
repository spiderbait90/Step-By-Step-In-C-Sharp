using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JSON_Stringify
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var collection = new List<Student>();
            var input = Console.ReadLine();

            while (input != "stringify")
            {
                var split = input.Split(new[] { ' ', ':', '>', '-', ',' },
                    StringSplitOptions.RemoveEmptyEntries);

                var student = new Student();
                student.Name = split[0];
                student.Age = int.Parse(split[1]);
                student.Grades=split.Skip(2).Select(int.Parse).ToList();
                collection.Add(student);

                input = Console.ReadLine();
            }
            var str = new StringBuilder();
            str = str.Append("[");
            foreach (var student in collection)
            {
                var stud = $"{{name:\"{student.Name}\"" +
                    $",age:{student.Age},grades:[{string.Join(", ",student.Grades)}]}}"+",";
                str = str.Append(stud);               
            }
            str = str.Remove(str.Length-1, 1);
            str = str.Insert(str.Length, "]");
            Console.WriteLine(str);
        }
    }
}
