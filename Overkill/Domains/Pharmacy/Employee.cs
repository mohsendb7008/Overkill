namespace Overkill.Domains.Pharmacy;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int PharmacyId { get; set; }
    public Pharmacy Pharmacy { get; set; }
}