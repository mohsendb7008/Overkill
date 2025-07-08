using Overkill.Comparer;

namespace Overkill;

public class MagicalMultiplier(IComparer<int, int> comparer) : IMultiplier<int, int, int>
{
    public int Multiply(int item1, int item2)
    {
        var compare = comparer.Compare(item1, item2);
        return compare switch
        {
            CompareResults.EqualTo => 0,
            CompareResults.LessThan => -(item1 * item2),
            CompareResults.GreaterThan => item1 * item2,
            CompareResults.InComparable => throw new NotImplementedException(),
            _ => throw new NotImplementedException()
        };
    }
}