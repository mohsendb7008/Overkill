namespace Overkill.Domains.Article;

public static class ArticleExtensions
{
    public static IQueryable<Article> DescendingYear(this IQueryable<Article> books) =>
        books.OrderByDescending(book => book.Year);
    public static IQueryable<Article> AscendingYear(this IQueryable<Article> books) =>
        books.OrderBy(book => book.Year);
    public static IQueryable<Article> AuthorNameContains(this IQueryable<Article> books, string text) =>
        books.Where(book => book.Author.Contains(text));
    public static IQueryable<Article> BookNameContains(this IQueryable<Article> books, string text) =>
        books.Where(book => book.Name.Contains(text));
    public static int AuthorCount(this IQueryable<Article> books, string author) =>
        books.Count(book => book.Author == author);
    public static string Text(this IQueryable<Article> books) =>
        string.Join("\n", books.Select(book => book.ToString()));
}