using Event_System.Application.Core.Abstractions.Messaging;

namespace Event_System.Application.Products.Commands.CreateProduct;

public sealed record CreateProductCommand(
    string Name, 
    string Description, 
    decimal Price,
    int Stock,
    List<string> Items) : ICommand<ProductDTO>;
