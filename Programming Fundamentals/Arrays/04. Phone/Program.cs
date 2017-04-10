using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var names = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var input = Console.ReadLine();

            while (input != "done")
            {
                string[] inputCopy = input.Split();
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (inputCopy[0] == "call" && inputCopy[1] == numbers[i])
                    {
                        Console.WriteLine($"calling {names[i]}...");
                        CallMethod(long.Parse(numbers[i]));
                    }
                    else if (inputCopy[0] == "call" && inputCopy[1] == names[i])
                    {
                        Console.WriteLine($"calling {numbers[i]}...");
                        CallMethod(long.Parse(numbers[i]));
                    }
                    else if (inputCopy[0] == "message" && inputCopy[1] == names[i])
                    {
                        Console.WriteLine($"sending sms to {numbers[i]}...");
                        MessageMethod(long.Parse(numbers[i]));
                    }
                    else if (inputCopy[0] == "message" && inputCopy[1] == numbers[i])
                    {
                        Console.WriteLine($"sending sms to {names[i]}...");
                        MessageMethod(long.Parse(numbers[i]));
                    }
                }
                input = Console.ReadLine();
            }
        }
        static void CallMethod(long number)
        {
            long sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
            else if (sum % 2 == 0)
            {
                var duration = new TimeSpan(0, 0, (int)sum).ToString(@"mm\:ss");
                Console.WriteLine($"call ended. duration: {duration}");
            }

        }
        static void MessageMethod(long number)
        {
            long diff = 0;

            while (number > 0)
            {
                diff -= number % 10;
                number /= 10;
            }
            if (diff % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else if (diff % 2 == 0)
            {

                Console.WriteLine($"meet me there");
            }

        }
    }
}
