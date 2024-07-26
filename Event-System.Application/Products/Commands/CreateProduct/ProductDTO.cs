namespace Event_System.Application.Products.Commands.CreateProduct;

public sealed record ProductDTO(
    string Name, 
    string Description, 
    decimal Price, 
    int Stock);
