using Overkill.Regex;

namespace Overkill.Transformer;

public class SimpleEquationTransformer : ITransformer<string, List<string>>
{
    private readonly StandardRegex _regex = new(@" [\+=] ");
    
    public List<string> Transform(string input) => _regex.Split(input).ToList();
}