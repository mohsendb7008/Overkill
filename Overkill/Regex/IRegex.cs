namespace Overkill.Regex;

public interface IRegex
{
    bool IsMatch(string input);
    IEnumerable<Match> Matches(string input);
    Match? MatchOrNull(string input);
    IEnumerable<string> Split(string input);
    string Replace(string input, string replacement);
}