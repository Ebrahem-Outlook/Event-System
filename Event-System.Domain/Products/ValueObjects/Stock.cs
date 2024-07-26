namespace Event_System.Domain.Products.ValueObjects;

public sealed class Stock
{
    private Stock(int value) => Value = value;

    public int Value { get; }

    public static Stock Create(int value)
    {
        return new  Stock(value);
    }
}
