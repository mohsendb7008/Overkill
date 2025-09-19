namespace Overkill.Domains.Article;

public class Article(string name, string author, int year)
{    
    public string Name { get; set; } = name;
    public string Author { get; set; } = author;
    public int Year { get; set; } = year;
    public override string ToString() => $"{Name} written by {Author} in {Year}";
}