using System.Text.Json.Serialization;

namespace Overkill.Domains.Library;

public class Book(string title, string isbn, int publicationYear)
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = title;

    [JsonPropertyName("isbn")]
    public string ISBN { get; set; } = isbn;

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("publication_year")]
    public int PublicationYear { get; set; } = publicationYear;

    [JsonPropertyName("editions")]
    public List<Edition> Editions { get; set; } = [];
    [JsonPropertyName("borrowing_history")]
    public List<BorrowingHistory> BorrowingHistory { get; set; } = [];
}
