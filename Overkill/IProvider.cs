namespace Overkill;

public interface IProvider<T>
{
    T Get();
    Task<T> GetAsync();
}