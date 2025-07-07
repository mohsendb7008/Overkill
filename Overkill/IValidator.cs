namespace Overkill;

public interface IValidator<in TItem>
{
    public void Validate(TItem item);
}