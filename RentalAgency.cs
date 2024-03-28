public class RentalAgency
{
    // Array to store instances of variables
    public Vehicle[] Fleet; 
    public double TotalRevenue { get; private set; } 

    // Constructor
    public RentalAgency(int fleetSize)
    {
        //Initializing the array with the input provided in main program
        Fleet = new Vehicle[fleetSize]; 
        TotalRevenue = 0;
    }

    // Method to add vehicles to the fleet
    public void AddVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == null)
            {
                Fleet[i] = vehicle;
                return;
            }
        }
    }

    // Method to remove vehicles from the fleet
    public void RemoveVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == vehicle)
            {
                Fleet[i] = null;
                return;
            }
        }
    }

    // Method to rent vehicles
    public void RentVehicle(Vehicle vehicle, int days)
    {
        if (vehicle != null)
        {
            double rentalCost = vehicle.RentalPrice * days;
            TotalRevenue += rentalCost;
        }
        else
        {
            Console.WriteLine("Invalid vehicle.");
        }
    }
}
