using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var command = input[0];
                var user = input[1];
                
                if (command=="register")
                {
                    var license = input[2];
                    if (data.ContainsKey(user))
                        Console.WriteLine
                            ($"ERROR: already registered with plate number" +
                            $" {data[user]}");

                    else if (data.ContainsValue(license))
                        Console.WriteLine($"ERROR: license plate {license} is busy");

                    else
                    {
                        bool ifValid = CheckIfInvalidLicense(license);

                        if (ifValid)
                        {
                            data.Add(user, license);
                            Console.WriteLine($"{user} registered {license} successfully");
                        }
                        else
                            Console.WriteLine($"ERROR: invalid license plate {license}");
                    }
                }
                else if (command== "unregister")
                {
                    if (!data.ContainsKey(user))
                        Console.WriteLine($"ERROR: user {user} not found");
                    else
                    {
                        data.Remove(user);
                        Console.WriteLine($"user {user} unregistered successfully");
                    }
                }
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        public static bool CheckIfInvalidLicense(string license)
        {
            if (license.Length != 8)
                return false;

            foreach (var item in license.Take(2))
            {
                if (!char.IsLetter(item))
                    return false;
                if (char.IsLower(item))
                    return false;
            }
            foreach (var item in license.Reverse().Take(2))
            {
                if (!char.IsLetter(item))
                    return false;
                if (char.IsLower(item))
                    return false;
            }

            foreach (var item in license.Skip(2).Take(4))
            {
                if (!char.IsDigit(item))
                    return false;
            }

            return true;
        }
    }
}
