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
        var engines = new List<Engine>();
        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var engineArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = engineArgs[0];
            var power = int.Parse(engineArgs[1]);
            int displacement = 0;
            string efficiency = "n/a";

            if (engineArgs.Length == 4)
            {
                displacement = int.Parse(engineArgs[2]);
                efficiency = engineArgs[3];

            }
            else if (engineArgs.Length == 3)
            {
                if (!int.TryParse(engineArgs[2], out displacement))
                {
                    efficiency = engineArgs[2];
                }
            }

            var engine = new Engine(model, power, displacement, efficiency);

            engines.Add(engine);
        }
        var m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            var carsInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var carModel = carsInput[0];
            var engineModel = carsInput[1];
            var weight = 0;
            var color = "n/a";

            if (carsInput.Length == 4)
            {
                weight = int.Parse(carsInput[2]);
                color = carsInput[3];
            }
            else if (carsInput.Length == 3)
            {
                if (!int.TryParse(carsInput[2], out weight))
                {
                    color = carsInput[2];
                }
            }
            var engine = engines.Find(x => x.Model == engineModel);

            var car = new Car(carModel, engine, weight, color);

            cars.Add(car);
        }

        foreach (var c in cars)
        {
            Console.WriteLine($"{c.Model}:");
            Console.WriteLine($"  {c.Engine.Model}:");
            Console.WriteLine($"    Power: {c.Engine.Power}");
            Console.WriteLine(c.Engine.Displacement == 0 ?
                $"    Displacement: n/a" :
                $"    Displacement: {c.Engine.Displacement}");
            Console.WriteLine($"    Efficiency: {c.Engine.Efficiency}");
            Console.WriteLine(c.Weight == 0 ? $"  Weight: n/a" : $"  Weight: {c.Weight}");
            Console.WriteLine($"  Color: {c.Color}");
        }
    }
}

