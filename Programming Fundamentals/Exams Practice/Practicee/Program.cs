using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var LastNumToString = GetLastNum(num);
            Console.WriteLine(LastNumToString);
        }

        public static string GetLastNum(string num)
        {

            var numInt = int.Parse(num);


            switch (numInt)
            {
                case 1:
                    num = "one";
                    break;
                case 2:
                    num = "two";
                    break;
                case 3:
                    num = "three";
                    break;
                case 4:
                    num = "four";
                    break;
                case 5:
                    num = "five";
                    break;
                case 6:
                    num = "six";
                    break;
                case 7:
                    num = "seven";
                    break;
                case 8:
                    num = "eight";
                    break;
                case 9:
                    num = "nine";
                    break;

            }

            return num;
        }
    }
}