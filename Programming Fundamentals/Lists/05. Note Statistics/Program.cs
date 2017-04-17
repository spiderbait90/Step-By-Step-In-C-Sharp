using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var frequenciesInuput = Console.ReadLine().Split(' ')
                .Select(double.Parse)
                .ToList();
            var notes = new List<string>();
            var Naturals = new List<string>(); var NaturalsSum = 0.0;
            var Sharps = new List<string>(); var SharpsSum = 0.0;
            for (int i = 0; i < frequenciesInuput.Count; i++)
            {
                switch (frequenciesInuput[i])
                {
                    case 261.63:
                        notes.Add("C");
                        NaturalsSum += frequenciesInuput[i]; break;
                    case 277.18:
                        notes.Add("C#");
                        SharpsSum += frequenciesInuput[i]; break;
                    case 293.66:
                        notes.Add("D");
                        NaturalsSum += frequenciesInuput[i]; break;
                    case 311.13:
                        notes.Add("D#");
                        SharpsSum += frequenciesInuput[i]; break;
                    case 329.63:
                        notes.Add("E");
                        NaturalsSum += frequenciesInuput[i]; break;
                    case 349.23:
                        notes.Add("F");
                        NaturalsSum += frequenciesInuput[i]; break;
                    case 369.99:
                        notes.Add("F#");
                        SharpsSum += frequenciesInuput[i]; break;
                    case 392.00:
                        notes.Add("G");
                        NaturalsSum += frequenciesInuput[i]; break;
                    case 415.30:
                        notes.Add("G#");
                        SharpsSum += frequenciesInuput[i]; break;
                    case 440.00:
                        notes.Add("A");
                        NaturalsSum += frequenciesInuput[i]; break;
                    case 466.16:
                        notes.Add("A#");
                        SharpsSum += frequenciesInuput[i]; break;
                    case 493.88:
                        notes.Add("B");
                        NaturalsSum += frequenciesInuput[i]; break;
                    default:break;
                }
            }
            foreach (var item in notes)
            {
                if (item.Length==1)
                {
                    Naturals.Add(item);
                }
                else
                {
                    Sharps.Add(item);
                }
            }
            Console.WriteLine($"Notes: {string.Join(" ",notes)}");
            Console.WriteLine($"Naturals: {string.Join(",", Naturals)}");
            Console.WriteLine($"Sharps: {string.Join(",", Sharps)}");
            Console.WriteLine($"Naturals sum: {NaturalsSum}");
            Console.WriteLine($"Sharps sum: {SharpsSum}");            
        }
    }
}
