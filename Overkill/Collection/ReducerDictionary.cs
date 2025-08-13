using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Overkill.Collection;

public class ReducerDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    where TKey : notnull
    where TValue : INumber<TValue>
{
    private readonly Dictionary<TKey, TValue> _backingField = new();
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return _backingField.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(KeyValuePair<TKey, TValue> item)
    {
        Add(item.Key, item.Value);
    }

    public void Clear()
    {
        _backingField.Clear();
    }

    public bool Contains(KeyValuePair<TKey, TValue> item)
    {
        return TryGetValue(item.Key, out var value) && item.Value == value;
    }

    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
    }

    public bool Remove(KeyValuePair<TKey, TValue> item)
    {
        if (_backingField.TryGetValue(item.Key, out var value) && value == item.Value)
            return Remove(item.Key);
        return false;
    }

    public int Count => _backingField.Count;
    public bool IsReadOnly => false;
    public void Add(TKey key, TValue value)
    {
        if (TryGetValue(key, out var existingValue))
            _backingField[key] = existingValue + value;
        else
            _backingField[key] = value;
    }

    public bool ContainsKey(TKey key)
    {
        return TryGetValue(key, out _);
    }

    public bool Remove(TKey key)
    {
        return _backingField.Remove(key);
    }

    public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
    {
        return _backingField.TryGetValue(key, out value);
    }

    public TValue this[TKey key]
    {
        get => _backingField[key];
        set => _backingField[key] = value;
    }

    public System.Collections.Generic.ICollection<TKey> Keys => _backingField.Keys;
    public System.Collections.Generic.ICollection<TValue> Values => _backingField.Values;
}