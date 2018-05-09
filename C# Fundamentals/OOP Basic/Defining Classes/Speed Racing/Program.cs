using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var data = new Dictionary<string, Car>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = input[0];
            var fuelAmount = decimal.Parse(input[1]);
            var fuelConsump = decimal.Parse(input[2]);

            data.Add(model, new Car()
            {
                Model = model,
                FuelAmount = fuelAmount,
                FuelConsump = fuelConsump
            });
        }

        while (true)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "End")
                break;

            var model = input[1];
            var km = decimal.Parse(input[2]);

            data[model].Move(km);
        }

        foreach (var car in data.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTravelled}");
        }
    }
}

