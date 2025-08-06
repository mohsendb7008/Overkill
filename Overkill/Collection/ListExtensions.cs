namespace Overkill.Collection;

public static class ListExtensions
{
    public static bool AllBiggerOrEqualThan(this List<int> list, int value) => list.All(x => x >= value);
    public static bool AllBiggerThan(this List<int> list, int value) => list.All(x => x > value);
    public static bool AllEqualTo(this List<int> list, int value) => list.All(x => x == value);
    public static bool AllLessOrEqualThan(this List<int> list, int value) => list.All(x => x <= value);
    public static bool AllLessThan(this List<int> list, int value) => list.All(x => x < value);
}