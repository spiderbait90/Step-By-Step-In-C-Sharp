using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cell = new List<List<char>>();
            ///Fill the list with char Lists:
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var chars = new List<char>();
                foreach (var charr in line)
                {
                    chars.Add(charr);
                }
                cell.Add(chars);
            }
            
            var directions = Console.ReadLine();

            var colonStart = 0;var rowStart = 0;            
            var countSteps = 0;

            /// Find Start Point:
            for (int row = 0; row < cell.Count; row++)
            {
                for (int col = 0; col < cell[row].Count; col++)
                {
                    if (cell[row][col]=='S')
                    {
                        colonStart = col;
                        rowStart = row;                        
                    }                    
                }
            }
            /// Directions Moving in cell
            foreach (var direction in directions)
            {
                if (direction=='D')
                {
                    rowStart++;
                    countSteps++;
                    if (rowStart > cell.Count - 1)
                        rowStart = 0;
                    else if (rowStart < 0)
                        rowStart = cell.Count - 1;
                    while (cell[rowStart].Count - 1 < colonStart)
                    {
                        rowStart++;                        
                        if (rowStart > cell.Count - 1)
                            rowStart = 0;
                    }

                }
                else if (direction=='U')
                {
                    rowStart--;
                    countSteps++;
                    if (rowStart > cell.Count - 1)
                        rowStart = 0;
                    else if (rowStart < 0)
                        rowStart = cell.Count - 1;
                    while (cell[rowStart].Count - 1 < colonStart)
                    {
                        rowStart--;                        
                        if (rowStart < 0)
                            rowStart = cell.Count - 1;
                    }
                }
                else if (direction=='R')
                {
                    colonStart++;
                    countSteps++;
                    if (colonStart > cell[rowStart].Count - 1)
                        colonStart = 0;
                    else if (colonStart < 0)
                        colonStart = cell[rowStart].Count - 1;
                }
                else if (direction=='L')
                {
                    colonStart--;
                    countSteps++;
                    if (colonStart > cell[rowStart].Count - 1)
                        colonStart = 0;
                    else if (colonStart < 0)
                        colonStart = cell[rowStart].Count - 1;
                }
                if (cell[rowStart][colonStart]=='E')
                {
                    Console.WriteLine($"Experiment successful. {countSteps} turns required.");
                    return;
                }
            }
            Console.WriteLine($"Robot stuck at {rowStart} {colonStart}. Experiment failed.");
        }
    }
}
