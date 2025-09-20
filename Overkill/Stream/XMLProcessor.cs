using System.Xml.Linq;

namespace Overkill.Stream;

public class XmlProcessor(string path)
{
    private readonly XDocument _xmlDoc = XDocument.Load(path);

    private int CalculateIncomes() =>
        _xmlDoc
            .Descendants("Income")
            .Select(x => int.Parse(x.Element("Amount").Value))
            .Sum();

    private int CalculateExpenses() =>
        _xmlDoc
            .Descendants("Expense")
            .Select(x => int.Parse(x.Element("Amount").Value))
            .Sum();

    private int CalculateSalaries() =>
        _xmlDoc
            .Descendants("Salary")
            .Select(x => int.Parse(x.Element("Amount").Value))
            .Sum();

    public int CalculateProfit() =>
        CalculateIncomes() - CalculateExpenses() - CalculateSalaries();
}