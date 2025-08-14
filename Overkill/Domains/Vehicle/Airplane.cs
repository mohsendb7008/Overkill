namespace Overkill.Domains.Vehicle;

public class Airplane(
   string name,
   decimal price,
   int numberOfSeats,
   int maxSpeed,
   string fuel,
   int numberOfFins,
   int numberOfWheels,
   string steeringWheel,
   string airline,
   int numberOfCrew,
   string captain)
   : FlyingVehicle(name, price, numberOfSeats, maxSpeed, fuel, numberOfFins, numberOfWheels, steeringWheel)
{
   public string Airline { get; set; } = airline;
   public int NumberOfCrew { get; set; } = numberOfCrew;
   public string Captain { get; set; } = captain;
}
