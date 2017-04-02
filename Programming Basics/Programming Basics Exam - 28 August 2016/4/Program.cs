using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var doctors = 7;var pregledani = 0;var nepregledani = 0;
            for (int i = 1; i <= n; i++)
            {
                var paciente = int.Parse(Console.ReadLine());
                if (i%3==0&&nepregledani>pregledani)
                {
                    doctors++;
                }
                if (paciente<=doctors) pregledani+= paciente;
                if (paciente > doctors)
                {
                    nepregledani =nepregledani+ (paciente - doctors);
                    pregledani += doctors;
                }
                
            }
            Console.WriteLine($"Treated patients: {pregledani}.");
            Console.WriteLine($"Untreated patients: {nepregledani}.");

        }

        }
    }

