namespace Overkill.Domains.Bank;

public class BankCard
{
    public Guid BankCardId { get; set; } = Guid.NewGuid();
    public string CardNumber { get; set; }
    public DateTime ExpirationDate { get; set; } = DateTime.Now.AddYears(5);

    public BankCard(string cardNumber)
    {
        CardNumber = cardNumber;
    }
}