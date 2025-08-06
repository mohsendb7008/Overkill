using System.Numerics;

namespace Overkill.Comparer;

public class NumberComparer<T> : IComparer<T, T> where T : INumber<T>
{
    public CompareResults Compare(T item1, T item2)
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