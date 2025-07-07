namespace Overkill;

public class NumberReverseTransformer : ITransformer<int, int>
{
    public int Transform(int input)
    {
        var inputString = input.ToString();
        var outputString = string.Join("", inputString.Reverse());
        return int.Parse(outputString);
    }
}