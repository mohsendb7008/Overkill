using Overkill.Comparer;
using Overkill.Exception;

namespace Overkill.Multiplier;

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
            CompareResults.InComparable => throw new InvalidArgumentException(""),
            _ => throw new InvalidArgumentException("")
        };
    }

    public Task<int> MultiplyAsync(int item1, int item2) => Task.FromResult(Multiply(item1, item2));
}