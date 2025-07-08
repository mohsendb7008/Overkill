namespace Overkill.Reader;

public class ConsoleReader : IReader<string>
{
    public string Read() => Console.ReadLine()!;

    public Task<string> ReadAsync() => Task.FromResult(Read());
}