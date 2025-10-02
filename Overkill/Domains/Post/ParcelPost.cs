using System.Text.Json;

namespace Overkill.Domains.Post;

public class ParcelPost
{
    public Letter Letter { get; set; }
    public string Name { get; set; } // Receiver's full name
    public string Address { get; set; }
    public string ReceiverPostalCode { get; set; }
    public string SenderPostalCode { get; set; }
    public bool IsReturned { get; set; }

    public ParcelPost() {}

    public ParcelPost(Letter letter, string name, string address, string receiverPostalCode, string senderPostalCode, bool isReturned)
    {
        Letter = letter;
        Name = name;
        Address = address;
        ReceiverPostalCode = receiverPostalCode;
        SenderPostalCode = senderPostalCode;
        IsReturned = isReturned;
    }

    public static void SaveToFile(Queue<ParcelPost> parcelQueue, string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonBytes = JsonSerializer.SerializeToUtf8Bytes(parcelQueue, options);
        using var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
        fs.Write(jsonBytes, 0, jsonBytes.Length);
    }
}