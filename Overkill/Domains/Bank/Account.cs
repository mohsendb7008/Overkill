namespace Overkill.Domains.Bank;

public abstract class Account()
{
    public decimal Amount { get; set; }
    public Guid AccountId { get; set; } = Guid.NewGuid();
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalId { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Account(
        decimal amount,
        string firstName,
        string lastName,
        string nationalId,
        string phoneNumber,
        string email,
        DateTime dateOfBirth
    ) : this()
    {
        Amount = amount;
        FirstName = firstName;
        LastName = lastName;
        NationalId = nationalId;
        PhoneNumber = phoneNumber;
        Email = email;
        DateOfBirth = dateOfBirth;
    }

    public abstract string GetAccountType();
}