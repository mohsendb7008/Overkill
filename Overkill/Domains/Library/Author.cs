using System.Text.Json.Serialization;

namespace Overkill.Domains.Library;

public class Author(string authorId, string name)
{
    [JsonPropertyName("author_id")]
    public string AuthorId { get; set; } = authorId;

    [JsonPropertyName("name")]
    public string Name { get; set; } = name;

    [JsonPropertyName("books")]
    public List<Book> Books { get; set; } = [];
}
