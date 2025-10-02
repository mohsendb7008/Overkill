using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Overkill.Domains.Post;

public class Letter : Data<string>
{
    public string Text { get; set; }
    public string ReceiverFullName { get; set; }
    public string SenderFullName { get; set; }
    public string LetterId { get => Key; set => Key = value; }

    public Letter() {}

    public Letter(string text, string receiverFullName, string senderFullName, string letterId)
    {
        Text = text;
        ReceiverFullName = receiverFullName;
        SenderFullName = senderFullName;
        LetterId = letterId;
        if (!Validate())
            throw new ValidationException("Invalid Letter data.");
    }

    public bool Validate()
    {
        return !string.IsNullOrWhiteSpace(LetterId) &&
               !string.IsNullOrWhiteSpace(SenderFullName) &&
               !string.IsNullOrWhiteSpace(ReceiverFullName) &&
               !string.IsNullOrWhiteSpace(Text);
    }

    public static Dictionary<string, Letter> LoadFromFile(string filePath)
    {
        var json = File.ReadAllText(filePath);
        var letterList = JsonSerializer.Deserialize<List<Letter>>(json);
        var letterDict = new Dictionary<string, Letter>();
        foreach (var data in letterList)
        {
            try
            {
                var letter = new Letter(
                    data.Text,
                    data.ReceiverFullName,
                    data.SenderFullName,
                    data.LetterId);
                letterDict[letter.LetterId] = letter;
            }
            catch (ValidationException)
            {
            }
        }
        return letterDict;
    }
}