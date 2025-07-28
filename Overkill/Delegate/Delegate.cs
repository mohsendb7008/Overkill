namespace Overkill.Delegate;

public delegate void Action();
public delegate void Action<in T1>(T1 arg1);
public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);

public delegate bool Predicate();
public delegate bool Predicate<in T1>(T1 arg1);
public delegate bool Predicate<in T1, in T2>(T1 arg1, T2 arg2);
public delegate bool Predicate<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);

public delegate TRes Func<out TRes>();
public delegate TRes Func<in T1, out TRes>(T1 arg1);
public delegate TRes Func<in T1, in T2, out TRes>(T1 arg1, T2 arg2);
public delegate TRes Func<in T1, in T2, in T3, out TRes>(T1 arg1, T2 arg2, T3 arg3);

public class Delegate(Action<string> printer, Predicate<int, int> matcher, Func<int, int, int> summer)
{
    public void InvokeAll(int value1, int value2)
    {
        var sum = summer(value1, value2);
        printer.Invoke(matcher(value1, value2) ? $"2 * {value1} = {sum}" : $"{value1} + {value2} = {sum}");
    }
}