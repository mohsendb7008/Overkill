using Overkill.Reader;

namespace Overkill.Provider;

public class IntProvider(IReader<string> reader) : IProvider<int>
{
    public int Get() => int.Parse(reader.Read());
}