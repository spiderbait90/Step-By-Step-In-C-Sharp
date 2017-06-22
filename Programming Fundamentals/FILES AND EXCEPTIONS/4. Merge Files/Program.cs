using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = File.ReadAllLines("Input1.txt");
            var input2 = File.ReadAllLines("Input2.txt");
            var output = input1.Concat(input2).OrderBy(x => x)
                .ToList();
            File.WriteAllLines("Output.txt", output);
        }
    }
}
