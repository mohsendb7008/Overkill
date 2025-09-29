namespace Overkill.Domains.Bank;

public class CurrentAccount : Account
{
    public List<Check> Checkbook { get; set; } = new List<Check>();
    public BankCard BankCard { get; set; } = new BankCard("");

    public override string GetAccountType()
    {
        return "Current Account";
    }
}