namespace Overkill;

public interface IMultiplier<in TItem1, in TItem2, out TResult>
{
    public TResult Multiply(TItem1 item1, TItem2 item2);
}