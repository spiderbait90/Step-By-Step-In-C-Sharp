using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    public string Model { get; set; }
    public decimal FuelAmount { get; set; }
    public decimal FuelConsump { get; set; }
    public decimal DistanceTravelled { get; set; }

    public void Move(decimal distance)
    {
        var km = distance * FuelConsump;

        if (km <= FuelAmount)
        {
            FuelAmount -= km;
            DistanceTravelled += distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}

