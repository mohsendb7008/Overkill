namespace Overkill.Domains.Library;

public class LibraryManager
{
    private Library _library = new();
    
    public Library GetLibrary()
    {
        return _library;
    }
    
    public void SetLibraryName(string name)
    {
        _library.Name = name;
    }
    
    public string GetLibraryName()
    {
        return _library.Name;
    }
    
    public void AddAuthor(Author author)
    {
        _library.Authors.Add(author);
    }

    public Author? FindAuthorById(string authorId)
    {
        return _library.Authors.Find(author => author.AuthorId == authorId);
    }

    public void RemoveAuthor(string authorId)
    {
        var author = FindAuthorById(authorId);
        if (author == null)
            return;
        _library.Authors.Remove(author);
    }
    
    public void AddBookToAuthor(string authorId, Book book)
    {
        var author = FindAuthorById(authorId);
        author?.Books.Add(book);
    }

    public Book? FindBookByIsbn(Author author, string isbn)
    {
        return author.Books.Find(book => book.ISBN == isbn);
    }

    public Book? FindBookByIsbn(string isbn)
    {
        return _library.Authors.Select(author => FindBookByIsbn(author, isbn)).FirstOrDefault(book => book != null);
    }

    public void RemoveBookFromAuthor(string authorId, string isbn)
    {
        var author = FindAuthorById(authorId);
        if (author == null)
            return;
        var book = FindBookByIsbn(author, isbn);
        if (book == null)
            return;
        author.Books.Remove(book);
    }
    
    public void AddEditionToBook(string isbn, Edition edition)
    {
        var book = FindBookByIsbn(isbn);
        book?.Editions.Add(edition);
    }
    
    public void RemoveEditionFromBook(string isbn, string editionCode)
    {
        var book = FindBookByIsbn(isbn);
        var edition = book?.Editions.Find(edition => edition.Code == editionCode);
        if (edition == null)
            return;
        book?.Editions.Remove(edition);
    }
    
    public void BorrowBook(string isbn, BorrowingHistory borrowingHistory)
    {
        var book = FindBookByIsbn(isbn);
        book?.BorrowingHistory.Add(borrowingHistory);
    }
    
    public void ReturnBook(string isbn, string browseId)
    {
        var book = FindBookByIsbn(isbn);
        var borrowing = book?.BorrowingHistory.Find(history => history.BorrowerId == browseId);
        if (borrowing != null) borrowing.IsReturned = true;
    }
    
    public string GetLibraryAsJson()
    {
        return System.Text.Json.JsonSerializer.Serialize(_library);
    }
    
    public void LoadLibraryFromJson(string json)
    {
        _library = System.Text.Json.JsonSerializer.Deserialize<Library>(json) ?? new Library();
    }
}