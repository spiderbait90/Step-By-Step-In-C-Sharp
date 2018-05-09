using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var originalFile = new FileStream(@"C:\Users\spide\Desktop\03. Streams-Exercise\copyMe.png", FileMode.Open))
            {
                using (var copyFile = new FileStream(@"C:\Users\spide\Desktop\03. Streams-Exercise\copyMe-Copy.png", FileMode.Create))
                {
                    var buffer = new byte[4096];

                    while (true)
                    {
                        var bytesCount = originalFile.Read(buffer, 0, buffer.Length);

                        if (bytesCount <= 0)
                            break;

                        copyFile.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
