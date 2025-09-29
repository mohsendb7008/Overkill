namespace Overkill.Domains.Bank;

public abstract class DepositAccount(
    decimal amount,
    string firstName,
    string lastName,
    string nationalId,
    string phoneNumber,
    string email,
    DateTime dateOfBirth,
    decimal profit)
    : Account(amount, firstName, lastName, nationalId, phoneNumber, email, dateOfBirth)
{
    public decimal Profit { get; set; } = profit;
    public abstract string DepositType { get; set; }
}