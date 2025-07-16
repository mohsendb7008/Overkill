namespace Overkill.Pharmacy;

public class Employee(string firstName, string lastName, int age)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public int Age { get; set; } = age;
}