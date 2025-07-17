namespace Overkill.Vehicle;

public sealed class B707(
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
    : Airplane(name, price, numberOfSeats, maxSpeed, fuel, numberOfFins, numberOfWheels, steeringWheel, airline,
        numberOfCrew, captain);