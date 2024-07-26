namespace Event_System.Domain.Products.ValueObjects;

public sealed class Description
{
    public const int MaxLength = 50;

    private Description(string value) => Value = value;

    public string Value { get; }

    public static Description Create(string value)
    {
        return new Description(value);
    }
}
