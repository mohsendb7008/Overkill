namespace Overkill.Domains.Bank;

public class QarzAlHasanahAccount : Account
{
    public BankCard BankCard { get; set; }

    public QarzAlHasanahAccount(BankCard bankCard) : base()
    {
        BankCard = bankCard;
    }

    public QarzAlHasanahAccount(
        decimal amount,
        string firstName,
        string lastName,
        string nationalID,
        string phoneNumber,
        string email,
        DateTime dateOfBirth,
        BankCard bankCard
    ) : base(amount, firstName, lastName, nationalID, phoneNumber, email, dateOfBirth)
    {
        BankCard = bankCard;
    }

    public override string GetAccountType()
    {
        return "Qarz-al-Hasanah Account";
    }
}