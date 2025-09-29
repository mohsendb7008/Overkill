namespace Overkill.Domains.Bank;

public class QarzAlHasanahAccount(
    decimal amount,
    string firstName,
    string lastName,
    string nationalId,
    string phoneNumber,
    string email,
    DateTime dateOfBirth,
    BankCard bankCard)
    : Account(amount, firstName, lastName, nationalId, phoneNumber, email, dateOfBirth)
{
    public BankCard BankCard { get; set; } = bankCard;

    public override string GetAccountType()
    {
        return "Qarz-al-Hasanah Account";
    }
}