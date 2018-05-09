using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryToTraverse = Console.ReadLine();
            var str = new StringBuilder();

            var files = Directory.GetFiles($@"{directoryToTraverse}")
                .Select(x => x.Split('\\').Last()).ToArray();
            
            var result = new Dictionary<string, Dictionary<string, decimal>>();
            foreach (var file in files)
            {
                var i = file.LastIndexOf('.');
                var ext = file.Substring(i);

                var fileinfo = new FileInfo($@"{directoryToTraverse}\{file}");
                decimal bytes = fileinfo.Length;
                decimal sizeKb = bytes / 1024;

                if (!result.ContainsKey(ext))
                    result[ext] = new Dictionary<string, decimal>();

                result[ext].Add(file, sizeKb);
            }
            
           
            foreach (var ext in result.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                str.AppendLine($"{ext.Key}");

                foreach (var x in ext.Value.OrderBy(x => x.Value))
                {
                    str.AppendLine($"--{x.Key} - {x.Value:f3} kb");
                }
            }
            
            File.WriteAllText(@"D:\",str.ToString());
        }
    }
}
