namespace Overkill.Domains.Pharmacy;

public class Drug
{
    public int DrugId { get; set; }
    public string Name { get; set; }
    public int Amount { get; set; }
    public int Price { get; set; }
    public int PharmacyId { get; set; }
    public Pharmacy Pharmacy { get; set; }
}