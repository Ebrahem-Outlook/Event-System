namespace Event_System.API.Contracts.Product;

public sealed record UpdateProductRequest(
    Guid ProductId,
    string Description,
    decimal Price,
    int Stock);
