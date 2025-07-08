namespace Overkill.Validator;

public interface IValidator<in TItem>
{
    public void Validate(TItem item);
    public Task ValidateAsync(TItem item);
}