//Motorcycle class inheriting properties from Vehicle class
public class Motorcycle : Vehicle
{
    // Properties of Motorcycle class in addition to base properties of Vehicle class
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    // Constructor including new and base class properties
    public Motorcycle(string model, string manufacturer, int year, double rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    // Override method to display motorcycle details along with the common Vehicle properties
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity}\nFuel Type: {FuelType}\nHas Fairing: {HasFairing}");
    }
}
