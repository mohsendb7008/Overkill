namespace Overkill.Exception;

public enum MathError { DivisionByZero }

public static class Calculator
{
    public static Result<double, MathError> Divide(double a, double b)
    {
        if (b == 0)
        {
            return MathError.DivisionByZero;
        }
        return a / b;
    }
}