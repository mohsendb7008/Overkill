using Overkill.Exception;

namespace Overkill.Validator;

public class Number3DigitValidator : IValidator<int>
{
    public bool Validate(int item) => item is < 100 or > 999;
    public void ValidateOrThrow(int item)
    {
        if (!Validate(item))
            throw new InvalidArgumentException("Provided number is not a valid 3 digit number.");
    }
}