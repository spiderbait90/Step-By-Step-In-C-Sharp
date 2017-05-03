using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var str = new StringBuilder();

            while (text != "collapse")
            {
                var word = Console.ReadLine();
                var index = 0;

                while (word.Length>0)
                {
                    index = text.IndexOf(word);
                    if (index!=-1)
                    text = text.Remove(index, word.Length);

                    if (index<0)
                    {
                        word = word.Remove(0,1);
                        if (word.Length>0)
                        word = word.Remove(word.Length-1);
                    }                    
                }
                
                if (text.Length == 0)
                    str.AppendLine("(void)");
                else
                    str.AppendLine(text.Trim());

                text = Console.ReadLine();
            }
            Console.Write(str.ToString());
        }
    }
}
