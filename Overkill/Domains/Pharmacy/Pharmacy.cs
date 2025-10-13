namespace Overkill.Domains.Pharmacy;

public class Pharmacy
{
    public int PharmacyId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public ICollection<Drug> Drugs { get; set; }
    public ICollection<Employee> Employees { get; set; }

    public int TotalPrice()
    {
        return Drugs.Sum(drug => drug.Price * drug.Amount);
    }

    public string EmployeeSummary()
    {
        return "Employees:\n" + string.Join("\n", Employees.Select((employee, index) => $"The employee number {index + 1} is {employee.FirstName} {employee.LastName} who is {employee.Age} years old.")) + "\n";
    }
}