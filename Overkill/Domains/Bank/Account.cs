namespace Overkill.Domains.Bank;

public abstract class Account
{
    public decimal Amount { get; set; }
    public Guid AccountId { get; set; }
    public DateTime CreateDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalID { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Account()
    {
        AccountId = Guid.NewGuid();
        CreateDate = DateTime.Now;
    }

    public Account(
        decimal amount,
        string firstName,
        string lastName,
        string nationalID,
        string phoneNumber,
        string email,
        DateTime dateOfBirth
    ) : this()
    {
        Amount = amount;
        FirstName = firstName;
        LastName = lastName;
        NationalID = nationalID;
        PhoneNumber = phoneNumber;
        Email = email;
        DateOfBirth = dateOfBirth;
    }

    public abstract string GetAccountType();
}