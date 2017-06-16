using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var skipList = new List<int>();
            var takeList = new List<int>();
            var text = new List<char>();
            var count = 0;
            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    if (count % 2 == 0)
                        takeList.Add(int.Parse(item.ToString()));
                    else
                        skipList.Add(int.Parse(item.ToString()));
                    count++;
                }
                else
                    text.Add(item);
            }
            var result = "";
            var sum = 0;
           
            for (int i = 0; i < skipList.Count; i++)
            {
                var strArr = text.Skip(sum)
                    .Take(takeList[i]).ToArray();
                
                sum += skipList[i]+takeList[i];

                var str = new string(strArr);
                result += str;
            }

            Console.WriteLine(result);
        }
    }
}
