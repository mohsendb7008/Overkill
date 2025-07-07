namespace Overkill;

public interface ITransformer<in TInput, out TOutput>
{
    public TOutput Transform(TInput input);
}