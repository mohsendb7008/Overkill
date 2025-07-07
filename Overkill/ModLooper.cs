namespace Overkill;

public class ModLooper : ILooper
{
    public void Loop(int from, int to, Action<int> forEach)
    {
        for (var i = 0; i < to; i++)
            forEach.Invoke((i + from) % to);
    }
}