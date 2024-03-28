public class Vehicle
{
    // Properties of the Vehicle class
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public double RentalPrice { get; set; }

    // Constructor for Vehicle class
    public Vehicle(string model, string manufacturer, int year, double rentalPrice)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrice = rentalPrice;
    }

    // Method to display the Vehicle Details in main program
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}\nManufacturer: {Manufacturer}\nYear: {Year}\nRental Price: {RentalPrice}");
    }
}

