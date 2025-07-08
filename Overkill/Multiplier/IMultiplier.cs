namespace Overkill.Multiplier;

public interface IMultiplier<in TItem1, in TItem2, TResult>
{
    public TResult Multiply(TItem1 item1, TItem2 item2);
    public Task<TResult> MultiplyAsync(TItem1 item1, TItem2 item2);
}