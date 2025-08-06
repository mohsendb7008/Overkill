namespace Overkill.Collection;

public class MagicList<T> : ListWrapper<T>
{
    public MagicList(int initialCount = 3)
    {
        for (var i = 0; i < initialCount; i++)
            base.Add(default);
    }

    public void Null()
    {
        List = null!;
    }

    public new bool Add(T item)
    {
        try
        {
            Add(item);
        }
        catch (NullReferenceException)
        {
            return false;
        }
        return true;
    }
}