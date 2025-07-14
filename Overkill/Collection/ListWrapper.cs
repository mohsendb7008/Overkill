namespace Overkill.Collection;

public class ListWrapper<T> : ICollection<T>
{
    private readonly List<T?> _list = [];
    
    public void Add(T? item) => _list.Add(item);
    
    public int Count => _list.Count;
    
    public void Clear() => _list.Clear();
    
    public T? Get(int index) => index >= 0 && index < Count ? _list[index] : default;
}