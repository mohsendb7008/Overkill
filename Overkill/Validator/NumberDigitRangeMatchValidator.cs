using Overkill.Exception;
using Overkill.Regex;

namespace Overkill.Validator;

public class NumberDigitRangeMatchValidator : IValidator<(string, int)>
{
    public bool Validate((string, int) item)
    {
        var regex = new StandardRegex($"^{item.Item1.Replace("#", @"\d*")}$");
        return regex.IsMatch(item.Item2.ToString());
    }

    public void ValidateOrThrow((string, int) item)
    {
       if (!Validate(item))
           throw new InvalidArgumentException("Number digit range did not match");
    }
}