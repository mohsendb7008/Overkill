namespace Overkill.Comparer;

public interface IComparer<in TItem1, in TItem2>
{
    public CompareResults Compare(TItem1 item1, TItem2 item2);
    public Task<CompareResults> CompareAsync(TItem1 item1, TItem2 item2);
}