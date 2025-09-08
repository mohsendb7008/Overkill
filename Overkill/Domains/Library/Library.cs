using System.Text.Json.Serialization;

namespace Overkill.Domains.Library;

public class Library
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("authors")]
    public List<Author> Authors { get; set; } = [];
}