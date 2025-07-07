namespace Overkill;

public class NumberComparer : IComparer<int, int>
{
    public CompareResults Compare(int item1, int item2)
    {
        if (item1 < item2)
            return CompareResults.LessThan;
        if (item1 > item2)
            return CompareResults.GreaterThan;
        if (item1 == item2)
            return CompareResults.EqualTo;
        return CompareResults.InComparable;
    }
}