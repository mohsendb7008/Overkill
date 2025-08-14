namespace Overkill.Domains.Vehicle;

public class Vehicle(string name, decimal price, int numberOfSeats, int maxSpeed)
   : object
{
   public string Name { get; set; } = name;
   public decimal Price { get; set; } = price;
   public int NumberOfSeats { get; set; } = numberOfSeats;
   public int MaxSpeed { get; set; } = maxSpeed;
}