namespace Event_System.Domain.Products.ValueObjects;

public sealed class Price
{
    private Price(decimal value) => Value = value;

    public decimal Value { get; }

    public static Price Create(decimal value)
    {
        return new Price(value);
    }
}
