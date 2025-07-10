using Overkill.Exception;
using Overkill.Regex;

namespace Overkill.Validator;

public class PhoneValidator : IValidator<string>
{
    protected readonly StandardRegex PhoneRegex = new(@"^(0|\+98|0098)9[\d]{9}$");

    public bool Validate(string item) => PhoneRegex.IsMatch(item);

    public void ValidateOrThrow(string item)
    {
        if (!Validate(item))
            throw new InvalidArgumentException("Input is not a valid phone number");
    }
}