namespace Overkill.Validator;

public interface IValidator<in TItem>
{
    public bool Validate(TItem item);
    public void ValidateOrThrow(TItem item);
}