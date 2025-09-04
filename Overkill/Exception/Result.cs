namespace Overkill.Exception;

public readonly struct Result<T, TError>
{
    private readonly T? _value;
    private readonly TError? _error;

    public bool IsSuccess { get; }

    public T? Value => IsSuccess 
        ? _value
        : throw new InvalidOperationException("Cannot access the value of an error result.");

    public TError? Error => !IsSuccess 
        ? _error
        : throw new InvalidOperationException("Cannot access the error of a success result.");

    private Result(T? value)
    {
        IsSuccess = true;
        _value = value;
        _error = default;
    }

    private Result(TError? error)
    {
        IsSuccess = false;
        _value = default;
        _error = error;
    }

    public static Result<T, TError> Ok(T? value) => new(value);
    public static Result<T, TError> Err(TError? error) => new(error);

    public static implicit operator Result<T, TError>(T? value) => Ok(value);
    public static implicit operator Result<T, TError>(TError? error) => Err(error);
}