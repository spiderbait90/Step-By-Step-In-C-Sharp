using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _______Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {           
                                        
                string strN = Console.ReadLine();
            try
            {
                long digit = long.Parse(strN);
                
                       Console.WriteLine($"{digit} can fit in:");
                    if (digit <= sbyte.MaxValue && digit >= sbyte.MinValue)
                        Console.WriteLine("* sbyte");
                    if (digit <= byte.MaxValue && digit >= byte.MinValue)
                        Console.WriteLine("* byte");
                    if (digit <= short.MaxValue && digit >= short.MinValue)
                        Console.WriteLine("* short");
                    if (digit <= ushort.MaxValue && digit >= ushort.MinValue)
                        Console.WriteLine("* ushort");
                    if (digit <= int.MaxValue && digit >= int.MinValue)
                        Console.WriteLine("* int");
                    if (digit <= uint.MaxValue && digit >= uint.MinValue)
                        Console.WriteLine("* uint");
                    if (digit <= long.MaxValue && digit >= long.MinValue)
                        Console.WriteLine("* long");
                
            }
            catch
            { 
                
                Console.WriteLine($"{strN} can't fit in any type");
            }        
                                                             
                                                
                       
                            
        }
    }
}
