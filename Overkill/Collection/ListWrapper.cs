namespace Overkill.Collection;

public class ListWrapper<T> : ICollection<T>
{
    protected List<T?> List = [];
    
    public void Add(T? item) => List.Add(item);
    
    public int Count => List.Count;
    
    public void Clear() => List.Clear();
    
    public T? Get(int index) => index >= 0 && index < Count ? List[index] : default;
    public void Pop() => List.RemoveAt(Count - 1); 
}