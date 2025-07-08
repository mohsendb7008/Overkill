namespace Overkill.Transformer;

public class NumberReverseTransformer : ITransformer<int, int>
{
    public int Transform(int input)
    {
        var inputString = input.ToString();
        var outputString = string.Join("", inputString.Reverse());
        return int.Parse(outputString);
    }

    public Task<int> TransformAsync(int input) => Task.FromResult(Transform(input));
}