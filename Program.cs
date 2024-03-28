using System;
class Program
{
    static void Main(string[] args)
    {
        // Creating a rental agency with a fleet size of 10 vehicles
        RentalAgency rentalAgency = new RentalAgency(10);

        // Creating instances of vehicles with different names
        Car car = new Car("Accord", "Toyota", 2022, 50.00, 5, "V6", "Automatic", false);
        Truck truck = new Truck("Ram", "Chevrolet", 2020, 100.00, 1000, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Raptor", "Ducati", 2021, 40.00, 500, "Gasoline", true);

        // Add vehicles to the fleet
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        // Display details of vehicles in the fleet
        Console.WriteLine("Details of Vehicles in the Fleet:");
        Console.WriteLine("**********************************");
        foreach (Vehicle vehicle in rentalAgency.Fleet)
        {
            if (vehicle != null) 
            {
                vehicle.DisplayDetails();
                Console.WriteLine("*******************************");
            }
        }

        // Rent a Motorcycle for 3 days and display the total revenue
        Console.WriteLine("------------------------------");
        Console.WriteLine("\nRenting a Motorcycle for 3 days...");
        rentalAgency.RentVehicle(rentalAgency.Fleet[2], 3);
        Console.WriteLine($"Total Revenue: ${rentalAgency.TotalRevenue}");
        Console.WriteLine("\n------------------------------");

        // Remove a vehicle from the fleet
        Console.WriteLine("Removing Motorcycle from the fleet...\n");
        rentalAgency.RemoveVehicle(rentalAgency.Fleet[2]);

        // Display the updated details of the fleet
        Console.WriteLine("Updated Vehicle Fleet Details:");
        Console.WriteLine("*******************************");
        foreach (Vehicle vehicle in rentalAgency.Fleet)
        {
            if (vehicle != null)
            {
                vehicle.DisplayDetails();
                Console.WriteLine("*******************************");
            }
        }
    }
}
