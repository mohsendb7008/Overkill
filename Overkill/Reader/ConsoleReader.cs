namespace Overkill.Reader;

public class ConsoleReader : IReader<string>
{
    public string Read() => Console.ReadLine()!;
}