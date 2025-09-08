using System.Text.Json.Serialization;

namespace Overkill.Domains.Library;

public class BorrowingHistory
{
    [JsonPropertyName("borrower_id")]
    public string BorrowerId { get; set; }
    [JsonPropertyName("borrowed_date")]
    public DateTime BorrowedDate { get; set; }
    [JsonPropertyName("is_returned")]
    public bool IsReturned { get; set; }
}