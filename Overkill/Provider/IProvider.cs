namespace Overkill.Provider;

public interface IProvider<out T>
{
    T Get();
}