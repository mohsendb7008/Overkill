namespace Overkill.Collection;

public class AdvancedQueue<T> : Queue<T>
{
    private Queue<T> ScanAndClone(Action<T, int> action)
    {
        Queue<T> clone = new();
        while (TryDequeue(out var item))
        {
            action(item, Count);
            clone.Enqueue(item);
        }
        return clone;
    }

    private void RollbackClone(Queue<T> clone)
    {
        while (clone.TryDequeue(out var item))
            Enqueue(item);
    }

    public T? PeekLast()
    {
        T? last = default;
        var clone = ScanAndClone((item, _) => last = item);
        RollbackClone(clone);
        return last;
    }

    public void InsertAtStart(T item)
    {
        var clone = ScanAndClone((_, _) => {});
        Enqueue(item);
        RollbackClone(clone);
    }
}