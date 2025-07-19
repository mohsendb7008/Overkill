namespace Overkill;

public class TradeRecord(int quantity, decimal pricePerUnit)
{
    public int Quantity { get; init; } = quantity;
    public decimal PricePerUnit { get; init; } = pricePerUnit;

    public decimal TotalValue => Quantity * PricePerUnit;

    public static TradeRecord operator+(TradeRecord a, TradeRecord b)
    {
        return new TradeRecord(a.Quantity + b.Quantity, (a.PricePerUnit + b.PricePerUnit) / 2);
    }

    public static TradeRecord operator-(TradeRecord a, TradeRecord b)
    {
        return new TradeRecord(a.Quantity - b.Quantity, a.PricePerUnit);
    }

    public static bool operator==(TradeRecord a, TradeRecord b)
    {
        return a.TotalValue == b.TotalValue;
    }

    public static bool operator!=(TradeRecord a, TradeRecord b)
    {
        return a.TotalValue != b.TotalValue;
    }

    public override string ToString()
    {
        return $"Quantity: {Quantity}, PricePerUnit: {PricePerUnit}, TotalValue: {TotalValue}";
    }
}
    