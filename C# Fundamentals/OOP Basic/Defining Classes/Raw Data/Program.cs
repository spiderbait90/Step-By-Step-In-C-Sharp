using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            var model = input[0];
            var engineSpeed = int.Parse(input[1]);
            var enginePower = int.Parse(input[2]);
            var cargoWeight = int.Parse(input[3]);
            var cargoType = input[4];
            var tire1Pressure = double.Parse(input[5]);
            var tire1Age = int.Parse(input[6]);
            var tire2Pressure = double.Parse(input[7]);
            var tire2Age = int.Parse(input[8]);
            var tire3Pressure = double.Parse(input[9]);
            var tire3Age = int.Parse(input[10]);
            var tire4Pressure = double.Parse(input[11]);
            var tire4Age = int.Parse(input[12]);

            var engine = new Engine(engineSpeed,enginePower);
            var cargo = new Cargo(cargoWeight,cargoType);
            var tires = new Tire[4];
            tires[0] = new Tire(tire1Age, tire1Pressure);
            tires[1] = new Tire(tire2Age, tire2Pressure);
            tires[2] = new Tire(tire3Age, tire3Pressure);
            tires[3] = new Tire(tire4Age, tire4Pressure);

            var car = new Car(model,engine,cargo,tires);

            cars.Add(car);
        }

        var command = Console.ReadLine();

        if (command == "fragile")
        {
            foreach (var c in cars
                .Where(x => x.Cargo.CargoType == "fragile")
                .Where(a => a.Tires.Any(b => b.Pressure < 1)))
            {
                Console.WriteLine(c.Model);
            }
        }
        else
        {
            foreach (var c in cars
                .Where(x => x.Cargo.CargoType == "flamable")
                .Where(a=>a.Engine.EnginePower>250))
            {
                Console.WriteLine(c.Model);
            }
        }
    }
}

