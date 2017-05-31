using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            var array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                var line = command.Split(' ');
                int[] args = new int[2];

                if (line[0].Equals("add") ||
                    line[0].Equals("subtract") ||
                    line[0].Equals("multiply"))
                {                    
                    args[0] = int.Parse(line[1]);
                    args[1] = int.Parse(line[2]);                    
                }

                PerformAction(ref array, line[0], args);

                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine();
            }
        }

        static void PerformAction(ref long[] arr, string action, int[] args)
        {            
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos-1] *= value;
                    break;
                case "add":
                    arr[pos-1] += value;
                    break;
                case "subtract":
                    arr[pos-1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(ref arr);
                    break;
                case "rshift":
                    ArrayShiftRight(ref arr);
                    break;
            }
        }

        private static void ArrayShiftRight(ref long[] array)
        {
            var temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }

        private static void ArrayShiftLeft(ref long[] array)
        {
            var temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
