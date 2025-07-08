namespace Overkill.Looper;

public interface ILooper
{
    public void Loop(int from, int to, Action<int> forEach);
    public Task LoopAsync(int from, int to, Action<int> forEach);
}