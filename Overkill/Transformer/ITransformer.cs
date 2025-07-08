namespace Overkill.Transformer;

public interface ITransformer<in TInput, TOutput>
{
    public TOutput Transform(TInput input);
    public Task<TOutput> TransformAsync(TInput input);
}