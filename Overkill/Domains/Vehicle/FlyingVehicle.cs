namespace Overkill.Domains.Vehicle;

public class FlyingVehicle(
    string name,
    decimal price,
    int numberOfSeats,
    int maxSpeed,
    string fuel,
    int numberOfFins,
    int numberOfWheels,
    string steeringWheel)
    : Vehicle(name, price, numberOfSeats, maxSpeed)
{
    public string Fuel { get; set; } = fuel;
    public int NumberOfFins { get; set; } = numberOfFins;
    public int NumberOfWheels { get; set; } = numberOfWheels;
    public string SteeringWheel { get; set; } = steeringWheel;
}