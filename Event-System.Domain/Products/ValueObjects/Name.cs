namespace Event_System.Domain.Products.ValueObjects;

public sealed class Name
{
    public const int MaxLength = 30;

    private Name(string value) => Value = value;

    public string Value { get; }

    public static Name Create(string name)
    {
        return new Name(name);
    }
}
