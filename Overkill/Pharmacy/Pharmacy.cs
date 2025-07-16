namespace Overkill.Pharmacy;

public class Pharmacy(string name)
{
    public string Name { get; set; } = name;
    private List<Drug> Drugs { get; set; } = new();
    private List<Employee> Employees { get; set; } = new();

    public void AddDrug(Drug drug)
    {
        Drugs.Add(drug);
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public int TotalPrice()
    {
        return Drugs.Sum(drug => drug.Price * drug.Amount);
    }

    public string EmployeeSummary()
    {
        return "Employees:\n" + string.Join("\n", Employees.Select((employee, index) => $"The employee number {index + 1} is {employee.FirstName} {employee.LastName} who is {employee.Age} years old.")) + "\n";
    }
}