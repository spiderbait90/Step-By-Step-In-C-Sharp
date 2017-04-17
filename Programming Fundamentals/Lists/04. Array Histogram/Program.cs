using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToArray();
            var count = 1;
            var wordList = new List<string>();
            var countList = new List<double>();
            for (int a = 0; a < words.Length; a++)
            {
                for (int b = a+1; b < words.Length; b++)
                {
                    if (words[a].CompareTo(words[b])==0)
                    {
                        count++;
                    }
                }
                if (wordList.Contains(words[a]))
                {
                    count = 1;
                }
                else
                {
                    wordList.Add(words[a]);
                    countList.Add(count);
                    count = 1;
                }
            }
            for (int i = 0; i < countList.Count-1; i++)
            {
                if (countList[i+1]>countList[i])
                {
                    var tempDigit = countList[i];
                    countList[i] = countList[i + 1];
                    countList[i + 1] = tempDigit;
                    var tempWord = wordList[i];
                    wordList[i] = wordList[i + 1];
                    wordList[i + 1] = tempWord;
                    i = -1;
                }
            }
            for (int i = 0; i < wordList.Count; i++)
            {
                Console.WriteLine($"{wordList[i]} -> {countList[i]} times ({(countList[i]/words.Length)*100:f2}%)");
            }
        }
    }
}
