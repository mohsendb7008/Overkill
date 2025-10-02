using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Overkill.Domains.Post;

public class Home : Data<string>
{
    public string OwnerNationalCode { get; set; }
    public decimal Price { get; set; }
    public string PostalCode { get => Key; set => Key = value; }
    public double Meterage { get; set; }
    public string Address { get; set; }

    public Home() {}

    public Home(string ownerNationalCode, decimal price, string postalCode, double meterage, string address)
    {
        OwnerNationalCode = ownerNationalCode;
        Price = price;
        PostalCode = postalCode;
        Meterage = meterage;
        Address = address;
        if (!Validate())
            throw new ValidationException("Invalid Home data.");
        
    }

    public bool Validate()
    {
        return IsValidNationalCode(OwnerNationalCode) &&
               IsValidPostalCode(PostalCode) &&
               Price >= 0 &&
               Meterage >= 0 &&
               !string.IsNullOrWhiteSpace(Address);
    }

    private static bool IsValidNationalCode(string nationalCode)
    {
        return System.Text.RegularExpressions.Regex.IsMatch(nationalCode, @"^\d{6}$");
    }

    private static bool IsValidPostalCode(string postalCode)
    {
        return System.Text.RegularExpressions.Regex.IsMatch(postalCode, @"^\d{6}$");
    }
    
    public static Dictionary<string, Home> LoadFromFile(string filePath)
    {
        var json = File.ReadAllText(filePath);
        var homeList = JsonSerializer.Deserialize<List<Home>>(json);
        var homeDict = new Dictionary<string, Home>();
        foreach (var data in homeList)
        {
            try
            {
                var home = new Home(
                    data.OwnerNationalCode,
                    data.Price,
                    data.PostalCode,
                    data.Meterage,
                    data.Address);
                homeDict[home.PostalCode] = home;
            }
            catch (ValidationException)
            {
            }
        }
        return homeDict;
    }
}