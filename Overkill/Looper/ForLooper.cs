namespace Overkill.Looper;

public class ForLooper : ILooper
{
    public void Loop(int from, int to, Action<int> forEach)
    {
        for (var i = from; i <= to; i++)
            forEach.Invoke(i);
    }

    public Task LoopAsync(int from, int to, Action<int> forEach)
    {
        Loop(from, to, forEach);
        return Task.CompletedTask;
    }
}