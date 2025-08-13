namespace Overkill.Collection;

public class AdvancedStack<T> : Stack<T>
{
    private Stack<T> ScanAndClone(Action<T, int> action)
    {
        Stack<T> clone = new();
        while (TryPop(out var item))
        {
            action(item, Count);
            clone.Push(item);
        }

        return clone;
    }

    private void RollbackClone(Stack<T> clone)
    {
        while (clone.TryPop(out var item))
            Push(item);
    }

    public T? PeekSecondLast()
    {
        T? secondLast = default;
        var clone = ScanAndClone((item, rem) =>
        {
            if (rem == 1)
                secondLast = item;
        });
        RollbackClone(clone);
        return secondLast;
    }

    public void InsertAtBottom(T item)
    {
        var clone = ScanAndClone((_, _) => {});
        Push(item);
        RollbackClone(clone);
    }
}