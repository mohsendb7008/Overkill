namespace Overkill.Domains.Bank;

public class CurrentAccount : Account
{
    public List<Check> Checkbook { get; set; } = [];
    public BankCard BankCard { get; set; } = new("");

    public override string GetAccountType()
    {
        return "Current Account";
    }
}