using Overkill.Exception;
using Overkill.Regex;

namespace Overkill.Validator;

public class RealNumberValidator : IValidator<string>
{
    private readonly StandardRegex _regex = new(@"^[\+-]?\d+(\.\d+)?([eE][\+-]?\d+)?$");
    public bool Validate(string item) => _regex.IsMatch(item);
    public void ValidateOrThrow(string item)
    {
        if (!Validate(item))
            throw new InvalidArgumentException("Not a valid real number");
    }
}