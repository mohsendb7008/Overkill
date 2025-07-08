namespace Overkill.Provider;

public interface IProvider<T>
{
    T Get();
    Task<T> GetAsync();
}