namespace Overkill.Collection;

public class MagicList
{
    private List<int>? _list;

    public MagicList()
    {
        Init();
    }

    public void Init()
    {
        _list = new List<int>(3);
    }

    public void Null()
    {
        _list = null;
    }

    public bool Add(int m)
    {
        try
        {
            _list!.Add(m);
        }
        catch (NullReferenceException)
        {
            return false;
        }
        return true;
    }

    public string Get(int n)
    {
        try
        {
            return _list![n].ToString();
        }
        catch (NullReferenceException)
        {
            return "nulle";
        }
        catch (ArgumentOutOfRangeException)
        {
            return "oute";
        }
    }
}