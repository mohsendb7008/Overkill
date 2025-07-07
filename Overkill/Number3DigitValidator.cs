namespace Overkill;

public class Number3DigitValidator : IValidator<int>
{
    public void Validate(int item)
    {
        if (item is < 100 or > 999)
            throw new InvalidArgumentException("Provider number is not a valid 3 digit number.");
    }
}