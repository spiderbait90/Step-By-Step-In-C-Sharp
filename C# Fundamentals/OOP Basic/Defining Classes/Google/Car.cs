public class Car
{
    public Car(string carModel, long carSpeed)
    {
        CarModel = carModel;
        CarSpeed = carSpeed;
    }
    
    public string CarModel { get; set; }

    public long CarSpeed { get; set; }
}