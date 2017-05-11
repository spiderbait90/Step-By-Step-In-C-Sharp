using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Dictionary<string, long>>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('\\');
                var fileTypeSize = input[input.Length - 1];
                var splitFile = fileTypeSize.Split(';');
                var root = input[0];
                var file = splitFile[0];
                var size = long.Parse(splitFile[1]);

                if (!data.ContainsKey(root))
                    data[root] = new Dictionary<string, long>();

                if (data[root].ContainsKey(file))
                    data[root][file] = size;

                else if (!data[root].ContainsKey(file))
                    data[root].Add(file, size);                        

            }
            var command = Console.ReadLine().Split(' ');
            var ext = command[0];
            var dir = command[2];

            var result = data.Where(x => x.Key == dir)
                .ToDictionary(x => x.Key, x => x.Value);
            var check = false;
            foreach (var item in result.Values)
            {
                foreach (var file in item.OrderByDescending(x=>x.Value)
                    .ThenBy(x=>x.Key))
                {
                    if (file.Key.ToString().EndsWith(ext))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                        check = true;
                    }
                }
            }
            if (!check)
                Console.WriteLine("No");
        }
    }
}
