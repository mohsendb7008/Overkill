using System.Collections;

namespace Overkill.Collection;

public class EndlessList<T> : ListWrapper<T>, IEnumerable<T>
{
    private class Enumerator<TItem>(List<TItem?> list) : IEnumerator<TItem>
    {
        private int _index = -1;

        public bool MoveNext()
        {
            _index = (_index + 1) % list.Count;
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }

        TItem IEnumerator<TItem>.Current => (list[_index] ?? default) ?? throw new InvalidOperationException();

        object? IEnumerator.Current => list[_index];

        public void Dispose()
        {
        }
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        return new Enumerator<T>(List);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}