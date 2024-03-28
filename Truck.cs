//Truck class inheriting properties from Vehicle class
public class Truck : Vehicle
{
    // Properties of Truck class in addition to base properties of Vehicle class
    public double Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // Constructor including new and base class properties
    public Truck(string model, string manufacturer, int year, double rentalPrice, double capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    // Override method to display truck details along with the common Vehicle properties
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity}\nTruck Type: {TruckType}\nFour Wheel Drive: {FourWheelDrive}");
    }
}
