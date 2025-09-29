namespace Overkill.Domains.Bank;

public class LongTermDepositAccount(
    decimal amount,
    string firstName,
    string lastName,
    string nationalId,
    string phoneNumber,
    string email,
    DateTime dateOfBirth,
    decimal profit)
    : DepositAccount(amount, firstName, lastName, nationalId, phoneNumber, email, dateOfBirth, profit)
{
    public override string GetAccountType()
    {
        return "Long-Term Deposit Account";
    }

    public override string DepositType { get; set; } = "Long-Term";
}