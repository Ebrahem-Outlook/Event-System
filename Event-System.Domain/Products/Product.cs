using Event_System.Domain.Core.BaseType;
using Event_System.Domain.Products.ValueObjects;

namespace Event_System.Domain.Products;

/// <summary>
/// 
/// </summary>
public sealed class Product : AggregateRoot, IAuditable, ISoftDeletable
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="stock"></param>
    /// <param name="photos"></param>
    public Product(Name name, Description description, Price price, Stock stock, List<Photo> photos)
        : base(Guid.NewGuid())
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        Photos = photos;
    }

    /// <summary>
    /// Required by EFCore.
    /// </summary>
    private Product() { }

    /// <summary>
    /// 
    /// </summary>
    public Name Name { get; private set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public Description Description { get; private set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public Price Price { get; private set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public Stock Stock { get; private set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public List<Photo> Photos { get; private set; } = [];

    /// <inheritdoc />
    public DateTime CreatedAt { get; }

    /// <inheritdoc />
    public DateTime? LastModifiedAt { get; private set; }

    public bool IsDeleted { get; private set; }

    public DateTime? DeletedAt { get; private set; }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="stock"></param>
    /// <returns></returns>
    public static Product Create(Name name, Description description, Price price, Stock stock, List<Photo> photos)
    {
        Product product = new(name, description, price, stock, photos);

        // Raise DomainEvent....

        return product;
    }

    /// <inheritdoc />
    public void Restore()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public void SoftDelete()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="stock"></param>
    public void Update(Name name, Description description, Price price, Stock stock)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;

        // Raise DomainEvent....
    }
}
