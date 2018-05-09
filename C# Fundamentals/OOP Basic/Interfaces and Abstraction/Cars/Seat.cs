using System;


public class Seat : ICar
{
    private string model;
    private string color;

    public Seat(string v1, string v2)
    {
        Model = v1;
        Color = v2;
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
        return $"{Color} {nameof(Seat)} {model}";
    }
}
