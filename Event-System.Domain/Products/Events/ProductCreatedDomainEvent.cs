using Event_System.Domain.Core.Events;

namespace Event_System.Domain.Products.Events;

/// <summary>
/// 
/// </summary>
public sealed record ProductCreatedDomainEvent : DomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="stock"></param>
    public ProductCreatedDomainEvent(Guid productId, string name, string description, decimal price, int stock)
        : base()
    {
        ProductId = productId;
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
    }

    /// <summary>
    /// 
    /// </summary>
    public Guid ProductId { get; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// 
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// 
    /// </summary>
    public decimal Price { get; }

    /// <summary>
    /// 
    /// </summary>
    public int Stock { get; }
}
