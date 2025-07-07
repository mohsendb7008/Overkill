namespace Overkill;

public class CompareResultOperatorTransformer : ITransformer<CompareResults, char>
{
    public char Transform(CompareResults input)
    {
        return input switch
        {
            CompareResults.LessThan => '<',
            CompareResults.EqualTo => '=',
            CompareResults.GreaterThan => '>',
            CompareResults.InComparable => '?',
            _ => throw new InvalidArgumentException("Operator not found for this compare result.")
        };
    }
}