using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new DirectoryInfo("TestFolder");
            var b = a.GetFiles();
            decimal sum = 0;
            foreach (var item in b)
            {
                sum += item.Length;
            }
            Console.WriteLine("size in bytes: "+sum);
        }
    }
}
