using System.Text.Json.Serialization;

namespace Overkill.Domains.Library;

public class Edition(string code, int publicationYear)
{
    [JsonPropertyName("code")]
    public string Code { get; set; } = code;

    [JsonPropertyName("publication_year")]
    public int PublicationYear { get; set; } = publicationYear;
}