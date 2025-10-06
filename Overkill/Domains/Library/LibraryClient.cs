using System.Net.Http.Json;

namespace Overkill.Domains.Library;

public class LibraryClient
{
    private readonly HttpClient _client = new();

    public async Task<string> AddBookAsync(Book book, string url)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(url),
            Content = JsonContent.Create(book)
        };
        var response = await _client.SendAsync(request);
        return response.IsSuccessStatusCode ? "Book added successfully" : "Failed to add the book";
    }

    public async Task<string> GetSingleCategoryForAllAsync(string url)
    {
        const string cantRecognize = "I can't recognize it";
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url)
        };
        var response = await _client.SendAsync(request);
        if (!response.IsSuccessStatusCode)
            return "Bad Request";
        var books = await response.Content.ReadFromJsonAsync<Book[]>();
        if (books == null || books.Length == 0)
            return cantRecognize;
        var category = books[0].Category;
        return books.All(book => book.Category == category) ? category : cantRecognize;
    }
}