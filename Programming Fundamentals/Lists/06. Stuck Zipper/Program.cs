using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            var upperZip = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
            var lowerZip = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
            var zippedResult = new List<int>();
            var minDigit =
                Math.Min(MinDigitCount(upperZip), MinDigitCount(lowerZip));        
            
            var index = 1;
            var countOfFirst = 0;
            for (int i = 0; i < lowerZip.Count; i++)
            {
                if (Math.Abs(lowerZip[i]).ToString().Length <= minDigit)
                {
                    zippedResult.Add(lowerZip[i]);
                    countOfFirst++;
                }
            }
            var countOfSecond = 0;
            for (int i = 0; i < upperZip.Count; i++)
            {
                if (Math.Abs(upperZip[i]).ToString().Length <= minDigit)
                {
                    if (countOfFirst>countOfSecond+1)
                    {
                        zippedResult.Insert(index, upperZip[i]);
                        index += 2;
                        countOfSecond++;
                    }
                    else
                    {
                        zippedResult.Add(upperZip[i]);
                    }                   
                }
            }
            Console.WriteLine(string.Join(" ",zippedResult));
        }
        public static int MinDigitCount(List<int> list)
        {
            var countDigits = 0;
            var minDigit = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] / 10 == 0)
                {
                    minDigit = 1;
                    break;
                }
                else
                {
                    var tempNumber = list[i];
                    while (tempNumber != 0)
                    {
                        tempNumber /= 10;
                        countDigits++;
                    }
                    if (minDigit > countDigits)
                        minDigit = countDigits;
                    countDigits = 0;
                }
            }
            return minDigit;
        }
    }
}
