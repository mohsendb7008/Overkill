namespace Overkill.Reader;

public interface IReader<out T>
{
    T Read();
}