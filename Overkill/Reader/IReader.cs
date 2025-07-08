namespace Overkill.Reader;

public interface IReader<T>
{
    T Read();
    Task<T> ReadAsync();
}