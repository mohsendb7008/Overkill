using Overkill.Validator;

namespace Overkill.Transformer;

public class HiddenEquationNumberTransformer(IValidator<string> hiddenNumberValidator) : ITransformer<List<string>, (int, int)>
{
    public (int, int) Transform(List<string> input)
    {
        if (hiddenNumberValidator.Validate(input[0]))
            return (0, int.Parse(input[2]) - int.Parse(input[1]));
        if (hiddenNumberValidator.Validate(input[1]))
            return (1, int.Parse(input[2]) - int.Parse(input[0]));
        if (hiddenNumberValidator.Validate(input[2]))
            return (2, int.Parse(input[0]) + int.Parse(input[1]));
        throw new InvalidOperationException();
    }
}