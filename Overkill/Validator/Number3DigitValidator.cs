using Overkill.Exception;

namespace Overkill.Validator;

public class Number3DigitValidator : IValidator<int>
{
    public bool Validate(int item) => item is < 100 or > 999;
    public void ValidateOrThrow(int item)
    {
        Validate(item);
        return Task.CompletedTask;
    }
}