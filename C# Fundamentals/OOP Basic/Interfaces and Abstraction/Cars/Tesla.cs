using System;



public class Tesla : ICar, IElectricCar
{
    private string model;
    private string color;
    private int battery;

    public Tesla(string v1, string v2, int v3)
    {
        Model = v1;
        Color = v2;
        Battery = v3;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public void Start()
    {
        Console.WriteLine("Engine start");
    }

    public void Stop()
    {
        Console.WriteLine("Breaaak!");
    }

    public override string ToString()
    {
        return $"{Color} {nameof(Tesla)} {model} with {Battery} Batteries";
    }

    public int Battery
    {
        get { return battery; }
        set { battery = value; }
    }
}
