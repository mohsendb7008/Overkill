using System.Collections.Concurrent;

namespace Overkill.Concurrency.ActorModel;

public abstract class Actor
{
    private readonly ConcurrentQueue<Func<Task>> _messageQueue = new();

    protected async Task SendAsync(Func<Task> messageHandler)
    {
        _messageQueue.Enqueue(messageHandler);
        await ProcessQueue();
    }

    private async Task ProcessQueue()
    {
        while (_messageQueue.TryDequeue(out var messageHandler))
            await messageHandler();
    }
}