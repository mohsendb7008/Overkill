namespace Overkill.Regex;

public class StandardRegex(string pattern) : IRegex
{
    public bool IsMatch(string input) => System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
    public IEnumerable<Match> Matches(string input) => System.Text.RegularExpressions.Regex.Matches(input, pattern)
        .Select(match => new Match(match.Index, match.Value));
    public Match? MatchOrNull(string input) => Matches(input).FirstOrDefault();
    public IEnumerable<string> Split(string input) => System.Text.RegularExpressions.Regex.Split(input, pattern);
    public string Replace(string input, string replacement) => System.Text.RegularExpressions.Regex.Replace(input, pattern, replacement);
}