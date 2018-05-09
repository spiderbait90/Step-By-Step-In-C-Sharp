using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var pets = new List<Pet>();
        var clinics = new List<Clinic>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            try
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = input[0];

                if (command == "Create")
                {
                    var kind = input[1];
                    if (kind == "Pet")
                    {
                        var pet = new Pet(input[2], int.Parse(input[3]), input[4]);
                        pets.Add(pet);
                    }
                    else if (kind == "Clinic")
                    {
                        var clinic = new Clinic(input[2], new Pet[int.Parse(input[3])]);
                        clinics.Add(clinic);
                    }
                }
                else if (command == "Add")
                {
                    var petToAdd = pets.FirstOrDefault(x => x.Name == input[1]);
                    var clinic = clinics.FirstOrDefault(x => x.Name == input[2]);

                    if (petToAdd == null ||
                        clinic == null)
                    {
                        throw new ArgumentException("no pet or clinic with that name");
                    }

                    Console.WriteLine(clinic.Add(petToAdd));

                }
                else if (command == "Release")
                {
                    var clinic = clinics.FirstOrDefault(x => x.Name == input[1]);

                    Console.WriteLine(clinic.Release());

                }
                else if (command == "HasEmptyRooms")
                {
                    var clinic = clinics.FirstOrDefault(x => x.Name == input[1]);

                    Console.WriteLine(clinic.HasEmptyRooms());

                }
                else if (command == "Print")
                {
                    var clinic = clinics.FirstOrDefault(x => x.Name == input[1]);
                    int room = 0;

                    if (input.Length == 3)
                        room = int.Parse(input[2]);

                    clinic.Print(room);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

