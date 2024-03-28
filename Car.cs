//Car class inheriting properties from Vehicle class
public class Car : Vehicle
{
    // Properties of Car class in addition to base properties of Vehicle class
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    // Constructor including new and base class properties
    public Car(string model, string manufacturer, int year, double rentalPrice, int seats, string engineType, string transmission, bool convertible)
        : base(model, manufacturer, year, rentalPrice)
    {
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
    }

    // Override method to display car details along with the common Vehicle properties
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Seats: {Seats}\nEngine Type: {EngineType}\nTransmission: {Transmission}\nConvertible: {Convertible}");
    }
}
