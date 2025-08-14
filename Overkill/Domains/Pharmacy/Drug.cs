namespace Overkill.Domains.Pharmacy;

public class Drug(string name, int amount, int price)
{
    public string Name { get; set; } = name;
    public int Amount { get; set; } = amount;
    public int Price { get; set; } = price;
}