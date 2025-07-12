using Overkill.Exception;
using Overkill.Regex;

namespace Overkill.Validator;

public class NumberDigitRangeHiddenValidator : IValidator<string>
{
    private readonly StandardRegex _regex = new(@"\d*#\d*");
    
    public bool Validate(string item) => _regex.IsMatch(item);
    
    public void ValidateOrThrow(string item)
    {
        if (!Validate(item))
            throw new InvalidArgumentException("Invalid number with # digit range");
    }
}