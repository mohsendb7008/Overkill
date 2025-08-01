namespace Overkill.Collection;

public static class ListExtensions
{
    public static bool AllBiggerOrEqualThan(this List<int> list, int value) => list.All(x => x >= value);
}