namespace Overkill.Collection;

public interface ICollection<T>
{
    public void Add(T? item);
    public int Count { get; }
    public void Clear();
    public T? Get(int index);
}