namespace Overkill.Domains.Bank;

public class BankCard(string cardNumber)
{
    public Guid BankCardId { get; set; } = Guid.NewGuid();
    public string CardNumber { get; set; } = cardNumber;
    public DateTime ExpirationDate { get; set; } = DateTime.Now.AddYears(5);
}