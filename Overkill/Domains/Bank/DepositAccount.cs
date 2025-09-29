namespace Overkill.Domains.Bank;

public abstract class DepositAccount : Account
{
    public decimal Profit { get; set; }
    public abstract string DepositType { get; set; }

    public DepositAccount(
        decimal amount,
        string firstName,
        string lastName,
        string nationalID,
        string phoneNumber,
        string email,
        DateTime dateOfBirth,
        decimal profit
    ) : base(amount, firstName, lastName, nationalID, phoneNumber, email, dateOfBirth)
    {
        Profit = profit;
    }
}