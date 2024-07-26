namespace Event_System.API.Contracts.Product;

public sealed record CreateProductRequest(
    string Name, 
    string Description, 
    decimal Price, 
    int Stock,
    List<string> Items);
