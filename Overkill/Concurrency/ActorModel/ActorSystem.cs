using System.Collections.Concurrent;

namespace Overkill.Concurrency.ActorModel;

public class ActorSystem
{
    private readonly ConcurrentDictionary<string, Actor> _actors = new();

    public T? CreateActor<T>(string actorId) where T : Actor, new()
    {
        var actor = new T();
        var success = _actors.TryAdd(actorId, actor);
        return success ? actor : null;
    }

    public Actor? GetActor(string actorId)
    {
        var success = _actors.TryGetValue(actorId, out var actor);
        return success ? actor : null;
    }
}
