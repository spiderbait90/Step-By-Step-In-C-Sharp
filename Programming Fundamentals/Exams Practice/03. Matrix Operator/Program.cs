using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Matrix_Operator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var r = int.Parse(Console.ReadLine());
            var table = new List<List<long>>();
            for (int i = 0; i < r; i++)
            {
                var arr = Console.ReadLine().Split()
                    .Select(long.Parse).ToList();
                table.Add(arr);
            }

            while (true)
            {
                var line = Console.ReadLine().Split();
                if (line[0] == "end")
                    break;
                var command = line[0];
                if (command == "remove")
                {
                    var type = line[1];
                    var rowOrCow = line[2];
                    var index = int.Parse(line[3]);

                    if (rowOrCow == "row")
                    {
                        switch (type)
                        {
                            case "positive":
                                table[index].RemoveAll(x => x >= 0); break;
                            case "negative":
                                table[index].RemoveAll(x => x < 0); break;
                            case "odd":
                                table[index].RemoveAll(x => x % 2 != 0); break;
                            case "even":
                                table[index].RemoveAll(x => x % 2 == 0); break;
                        }
                    }
                    else
                    {
                        switch (type)
                        {
                            case "positive":
                                RemovePositive(ref table, index); break;
                            case "negative":
                                RemoveNegative(ref table, index); break;
                            case "odd":
                                RemoveOdd(ref table, index); break;
                            case "even":
                                RemoveEven(ref table, index); break;
                        }
                    }
                }
                else if (command == "swap")
                {
                    var firstRow = int.Parse(line[1]);
                    var secondRow = int.Parse(line[2]);
                    var temp = table[firstRow];
                    table[firstRow] = table[secondRow];
                    table[secondRow] = temp;
                }
                else if (command == "insert")
                {
                    var row = int.Parse(line[1]);
                    var element = long.Parse(line[2]);
                    table[row].Insert(0, element);
                }
            }
            foreach (var arr in table)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }

        public static void RemoveEven(ref List<List<long>> table, int index)
        {
            for (int a = 0; a < table.Count; a++)
            {
                if (table[a].Count - 1 >= index)
                {
                    if (table[a][index] % 2 == 0)
                    {
                        table[a].RemoveAt(index);
                    }
                }
            }
        }

        public static void RemoveOdd(ref List<List<long>> table, int index)
        {
            for (int a = 0; a < table.Count; a++)
            {
                if (table[a].Count - 1 >= index)
                {
                    if (table[a][index] % 2 != 0)
                    {
                        table[a].RemoveAt(index);
                    }
                }
            }
        }

        public static void RemoveNegative(ref List<List<long>> table, int index)
        {
            for (int a = 0; a < table.Count; a++)
            {
                if (table[a].Count - 1 >= index)
                {
                    if (table[a][index] < 0)
                    {
                        table[a].RemoveAt(index);
                    }
                }
            }
        }

        public static void RemovePositive(ref List<List<long>> table, int index)
        {
            for (int a = 0; a < table.Count; a++)
            {
                if (table[a].Count - 1 >= index)
                {
                    if (table[a][index] >= 0)
                    {
                        table[a].RemoveAt(index);
                    }
                }
            }
        }
    }
}