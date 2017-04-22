using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var age = new Dictionary<string, int>();
            var salary = new Dictionary<string, double>();
            var position = new Dictionary<string, string>();

            while (input != "filter base")
            {
                var name0other1 =
                    input.Split(new[] { ' ', '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);

                var floating = 0.0; var intiger = 0;

                if (int.TryParse(name0other1[1], out intiger))
                {
                    age[name0other1[0]] = intiger;
                }
                else if (double.TryParse(name0other1[1], out floating))
                {
                    salary[name0other1[0]] = floating;
                }
                else
                {
                    position[name0other1[0]] = name0other1[1];
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            if (input== "Position")
            {
                foreach (var kv in position)
                {
                    Console.WriteLine($"Name: {kv.Key}");
                    Console.WriteLine($"Position: {kv.Value}");
                    Console.WriteLine("====================");
                }
            }
            else if (input == "Salary")
            {
                foreach (var kv in salary)
                {
                    Console.WriteLine($"Name: {kv.Key}");
                    Console.WriteLine($"Salary: {kv.Value:f2}");
                    Console.WriteLine("====================");
                }
            }
            else if (input == "Age")
            {
                foreach (var kv in age)
                {
                    Console.WriteLine($"Name: {kv.Key}");
                    Console.WriteLine($"Age: {kv.Value}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
