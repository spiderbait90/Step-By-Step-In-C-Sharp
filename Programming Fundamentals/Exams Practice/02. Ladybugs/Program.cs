using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = new int[int.Parse(Console.ReadLine())];

            var bugs = Console.ReadLine().Split(' ').Select(long.Parse)
                .ToList();

            for (int i = 0; i < field.Length; i++)
            {
                for (int i2 = 0; i2 < bugs.Count; i2++)
                {
                    if (i == bugs[i2])
                        field[i] = 1;                    
                }
            }

            var input = Console.ReadLine();

            while (input!="end")
            {
                var split = input.Split(' ');

                var index = long.Parse(split[0]);
                var LeftOrRight = split[1];
                var lenght = long.Parse(split[2]);
                
                if (field.Length - 1 < index||index<0)
                {
                    /// do nothing
                }
                else if (field[index]==0)
                {
                    /// do nothing
                }
                else
                {
                    field[index] = 0;
                    if (LeftOrRight=="left")
                    {
                        while (true)
                        {
                            index = index - lenght;
                            if (index < 0||index>field.Length-1)
                                break;

                            else if (field[index] == 0)
                            {
                                field[index] = 1;
                                break;
                            }
                        }
                    }
                    else if (LeftOrRight=="right")
                    {
                        while (true)
                        {
                            index = index + lenght;
                            if (index < 0 || index > field.Length - 1)
                                break;

                            else if (field[index] == 0)
                            {
                                field[index] = 1;
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
