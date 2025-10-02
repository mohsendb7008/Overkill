using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Overkill.Domains.Post;

public class Person : Data<string>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get => Key; set => Key = value; }
    public string BirthDate { get; set; }
    public string BirthPlace { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Person() {}

    public Person(string firstName, string lastName, string nationalCode, string birthDate, string birthPlace, string phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalCode = nationalCode;
        BirthDate = birthDate;
        BirthPlace = birthPlace;
        PhoneNumber = phoneNumber;
        Email = email;
        if (!Validate())
            throw new ValidationException("Invalid Person data.");
    }

    public bool Validate()
    {
        return IsValidNationalCode(NationalCode) &&
               IsValidPhoneNumber(PhoneNumber) &&
               IsValidEmail(Email);
    }

    public static Dictionary<string, Person> LoadFromFile(string filePath)
    {
        var json = File.ReadAllText(filePath);
        var personList = JsonSerializer.Deserialize<List<Person>>(json);
        var personDict = new Dictionary<string, Person>();
        foreach (var data in personList)
        {
            try
            {
                var person = new Person(
                    data.FirstName,
                    data.LastName,
                    data.NationalCode,
                    data.BirthDate,
                    data.BirthPlace,
                    data.PhoneNumber,
                    data.Email);
                personDict[person.NationalCode] = person;
            }
            catch (ValidationException)
            {
            }
        }
        return personDict;
    }

    private static bool IsValidNationalCode(string nationalCode)
    {
        return System.Text.RegularExpressions.Regex.IsMatch(nationalCode, @"^\d{6}$");
    }

    private static bool IsValidPhoneNumber(string phoneNumber)
    {
        return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^09\d{9}$");
    }

    private static bool IsValidEmail(string email)
    {
        return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}