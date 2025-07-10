using Overkill.Exception;
using Overkill.Regex;

namespace Overkill.Validator;

public class EmailValidator : IValidator<string>
{
    protected readonly StandardRegex EmailRegex = new(@"^[\w\.]+@[a-zA-Z0-9]+\.[a-zA-Z]{3}$");

    public bool Validate(string item) => EmailRegex.IsMatch(item);

    public void ValidateOrThrow(string item)
    {
        if (!Validate(item))
            throw new InvalidArgumentException("Input is not a valid email address");
    }
}