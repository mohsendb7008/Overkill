namespace Overkill;

public interface IReader<T>
{
    T Read();
    Task<T> ReadAsync();
}